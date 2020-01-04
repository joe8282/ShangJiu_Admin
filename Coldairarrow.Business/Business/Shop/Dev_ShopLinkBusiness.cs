using Coldairarrow.Entity.Shop;
using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;


namespace Coldairarrow.Business.Shop
{
    public class Dev_ShopLinkBusiness : BaseBusiness<Dev_ShopLink>, IDev_ShopLinkBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_ShopLinkDTO> GetDataList(Pagination pagination, bool all, string shopId, string linkId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime)
        {
            Expression<Func<Dev_ShopLink, Base_User, Dev_Shop, Dev_Shop, Dev_ShopLinkDTO>> select = (a, b, c, d) => new Dev_ShopLinkDTO
            {
                UserName = b.UserName,
                RealName = b.RealName,
                Phone = b.Phone,
                ShopTitle = c.ShopTitle,
                LinkTitle = d.ShopTitle,
            };
            select = select.BuildExtendSelectExpre();
            var q_ShopLink = all ? Service.GetIQueryable<Dev_ShopLink>() : GetIQueryable();
            var q = from a in q_ShopLink.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                    join c in Service.GetIQueryable<Dev_Shop>() on a.ShopId equals c.Id
                    join d in Service.GetIQueryable<Dev_Shop>() on a.LinkId equals d.Id
                    select @select.Invoke(a, b, c, d);

            var where = LinqHelper.True<Dev_ShopLinkDTO>();
            if (!userId.IsNullOrEmpty())
                where = where.And(x => x.UserId == userId);
            if (!shopId.IsNullOrEmpty())
                where = where.And(x => x.ShopId == shopId);
            if (!linkId.IsNullOrEmpty())
                where = where.And(x => x.LinkId == linkId);
            if (!Status.IsNullOrEmpty())
                where = where.And(x => x.Status == Status);
            if (!startTime.IsNullOrEmpty())
                where = where.And(x => x.CreateTime >= startTime);
            if (!endTime.IsNullOrEmpty())
                where = where.And(x => x.CreateTime <= endTime);
            if (!keyword.IsNullOrEmpty())
            {
                where = where.And(x =>
                    x.ShopTitle.Contains(keyword)
                    || x.LinkTitle.Contains(keyword));
            }
            if (!username.IsNullOrEmpty())
            {
                where = where.And(x =>
                    x.UserName.Contains(username)
                    || x.RealName.Contains(username)
                    || x.Phone.Contains(username));
            }

            return q.Where(where).GetPagination(pagination).ToList();
        }

        public Dev_ShopLink GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_ShopLink newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_ShopLink theData)
        {
            Update(theData);

            return Success();
        }

        public AjaxResult DeleteData(List<string> ids)
        {
            Delete(ids);

            return Success();
        }

        #endregion

        #region 私有成员

        #endregion

        #region 数据模型

        #endregion
    }
}