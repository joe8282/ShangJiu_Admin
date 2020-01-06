using Coldairarrow.Entity.Shop;
using Coldairarrow.Entity.Product;
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
    public class Dev_ShopProductBusiness : BaseBusiness<Dev_ShopProduct>, IDev_ShopProductBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_ShopProductDTO> GetDataList(Pagination pagination, bool all, string shopId, string productId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime)
        {
            Expression<Func<Dev_ShopProduct, Base_User, Dev_Shop, Dev_Product, Dev_ShopProductDTO>> select = (a, b, c, d) => new Dev_ShopProductDTO
            {
                UserName = b.UserName,
                RealName = b.RealName,
                Phone = b.Phone,
                ShopTitle = c.ShopTitle,
                ProductTitle = d.ProductTitle,
            };
            select = select.BuildExtendSelectExpre();
            var q_ShopProduct = all ? Service.GetIQueryable<Dev_ShopProduct>() : GetIQueryable();
            var q = from a in q_ShopProduct.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                    join c in Service.GetIQueryable<Dev_Shop>() on a.ShopId equals c.Id
                    join d in Service.GetIQueryable< Dev_Product>() on a.ProductId equals d.Id
                    select @select.Invoke(a, b, c, d);

            var where = LinqHelper.True<Dev_ShopProductDTO>();
            if (!userId.IsNullOrEmpty())
                where = where.And(x => x.UserId == userId);
            if (!shopId.IsNullOrEmpty())
                where = where.And(x => x.ShopId == shopId);
            if (!productId.IsNullOrEmpty())
                where = where.And(x => x.ProductId == productId);
            if (!Status.IsNullOrEmpty())
                where = where.And(x => x.Status == Status);
            if (!startTime.IsNullOrEmpty())
                where = where.And(x => DbFunctions.TruncateTime(x.CreateTime) >= startTime);
            if (!endTime.IsNullOrEmpty())
                where = where.And(x => DbFunctions.TruncateTime(x.CreateTime) <= endTime);
            if (!keyword.IsNullOrEmpty())
            {
                where = where.And(x =>
                    x.ShopTitle.Contains(keyword)
                    || x.ProductTitle.Contains(keyword));
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

        public Dev_ShopProduct GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_ShopProduct newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_ShopProduct theData)
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