using Coldairarrow.Entity.Shop;
using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
<<<<<<< HEAD
using System.Linq.Expressions;

namespace Coldairarrow.Business.Shop
{
    public class Dev_ShopBusiness : BaseBusiness<Dev_Shop>, IDev_ShopBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_ShopDTO> GetDataList(Pagination pagination, bool all, string userId = null, string TypeId = null, string ClassId = null, string ChannelId = null, string keyword = null)
=======
using System.Linq.Expressions;

namespace Coldairarrow.Business.Shop
{
    public class Dev_ShopBusiness : BaseBusiness<Dev_Shop>, IDev_ShopBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_ShopDTO> GetDataList(Pagination pagination, bool all, string userId, string TypeId, string ClassId, string ChannelId, int? JoinWay, int? IsAd, int? IsTop, int? IsRefresh, int? HasReward, int? Status, string keyword, DateTime? startTime, DateTime? endTime)
>>>>>>> 39ca4f60a40845dafcd96c41f97a64a947a0c658
        {
            Expression<Func<Dev_Shop, Base_User, Dev_Type, Dev_Type, Dev_Type, Dev_ShopDTO>> select = (a, b, c1, c2, c3) => new Dev_ShopDTO
            {
                UserName = b.UserName,
                RealName = b.RealName,
                Phone = b.Phone,
                TypeName = c1.Name,
                ClassName = c2.Name,
                ChannelName = c3.Name
            };
            select = select.BuildExtendSelectExpre();
            var q_Shop = all ? Service.GetIQueryable<Dev_Shop>() : GetIQueryable();
            var q = from a in q_Shop.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                    join c1 in Service.GetIQueryable<Dev_Type>() on a.TypeId equals c1.Id
                    join c2 in Service.GetIQueryable<Dev_Type>() on a.ClassId equals c2.Id
                    join c3 in Service.GetIQueryable<Dev_Type>() on a.ChannelId equals c3.Id
                    select @select.Invoke(a, b, c1, c2, c3);

            var where = LinqHelper.True<Dev_ShopDTO>();
            if (!userId.IsNullOrEmpty())
                where = where.And(x => x.UserId == userId);
            if (!TypeId.IsNullOrEmpty())
                where = where.And(x => x.TypeId == TypeId);
            if (!ClassId.IsNullOrEmpty())
                where = where.And(x => x.ClassId == ClassId);
            if (!ChannelId.IsNullOrEmpty())
                where = where.And(x => x.ChannelId == ChannelId);
            if (!JoinWay.IsNullOrEmpty())
                where = where.And(x => x.JoinWay == JoinWay);
            if (!startTime.IsNullOrEmpty())
                where = where.And(x => x.CreateTime >= startTime);
            if (!endTime.IsNullOrEmpty())
                where = where.And(x => x.CreateTime <= endTime);
            if (!keyword.IsNullOrEmpty())
            {
                where = where.And(x =>
                    x.ShopTitle.Contains(keyword)
                    || x.UserName.Contains(keyword)
                    || x.RealName.Contains(keyword));
            }

            return q.Where(where).GetPagination(pagination).ToList();
        }

        public Dev_Shop GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Shop newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Shop theData)
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