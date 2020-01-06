using Coldairarrow.Entity.Shop;
using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Coldairarrow.Business.Shop
{
    public class Dev_ShopMemberBusiness : BaseBusiness<Dev_ShopMember>, IDev_ShopMemberBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_ShopMemberDTO> GetDataList(Pagination pagination, bool all, string shopId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime)
        {
            Expression<Func<Dev_ShopMember, Base_User, Dev_Shop, Dev_ShopMemberDTO>> select = (a, b, c) => new Dev_ShopMemberDTO
            {
                UserName = b.UserName,
                RealName = b.RealName,
                Phone = b.Phone,
                ShopTitle = c.ShopTitle,
            };
            select = select.BuildExtendSelectExpre();
            var q_ShopMember = all ? Service.GetIQueryable<Dev_ShopMember>() : GetIQueryable();
            var q = from a in q_ShopMember.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                    join c in Service.GetIQueryable<Dev_Shop>() on a.ShopId equals c.Id
                    select @select.Invoke(a, b, c);

            var where = LinqHelper.True<Dev_ShopMemberDTO>();
            if (!userId.IsNullOrEmpty())
                where = where.And(x => x.UserId == userId);
            if (!shopId.IsNullOrEmpty())
                where = where.And(x => x.ShopId == shopId);
            if (!Status.IsNullOrEmpty())
                where = where.And(x => x.Status == Status);
            if (!startTime.IsNullOrEmpty())
                where = where.And(x => DbFunctions.TruncateTime(x.CreateTime) >= startTime);
            if (!endTime.IsNullOrEmpty())
                where = where.And(x => DbFunctions.TruncateTime(x.CreateTime) <= endTime);
            if (!keyword.IsNullOrEmpty())
                where = where.And(x => x.ShopTitle.Contains(keyword));
            if (!username.IsNullOrEmpty())
            {
                where = where.And(x =>
                    x.UserName.Contains(username)
                    || x.RealName.Contains(username)
                    || x.Phone.Contains(username));
            }

            return q.Where(where).GetPagination(pagination).ToList();
        }

        public Dev_ShopMember GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_ShopMember newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_ShopMember theData)
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