using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Entity.Product;
using Coldairarrow.Entity.Shop;
using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Coldairarrow.Business.Product
{
    public class Dev_ProductBusiness : BaseBusiness<Dev_Product>, IDev_ProductBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_ProductDTO> GetDataList(Pagination pagination, string TypeId, string ClassId,
            string ChannelId, int? IsAd, int? FeeWay, string UserName, int? Status,
            string ProductTitle, DateTime? startTime, DateTime? endTime)
        {
            Expression<Func<Dev_Product, Base_User, Dev_Type, Dev_Type, Dev_Type, Dev_ProductDTO>> select = (a, b, c1, c2, c3) => new Dev_ProductDTO
            {
                UserName = b.UserName,
                RealName = b.RealName,
                Phone = b.Phone,
                TypeName = c1.Name,
                ClassName = c2.Name,
                ChannelName = c3.Name
            };
            select = select.BuildExtendSelectExpre();
            var q_Product = GetIQueryable();
            var q = from a in q_Product.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                    join c1 in Service.GetIQueryable<Dev_Type>() on a.TypeId equals c1.Id
                    join c2 in Service.GetIQueryable<Dev_Type>() on a.ClassId equals c2.Id
                    join c3 in Service.GetIQueryable<Dev_Type>() on a.ChannelId equals c3.Id
                    select @select.Invoke(a, b, c1, c2, c3);

            var where = LinqHelper.True<Dev_ProductDTO>();
            if (!UserName.IsNullOrEmpty())
                where = where.And(x => x.UserName.Contains(UserName));
            if (!TypeId.IsNullOrEmpty())
                where = where.And(x => x.TypeId == TypeId);
            if (!ClassId.IsNullOrEmpty())
                where = where.And(x => x.ClassId == ClassId);
            if (!ChannelId.IsNullOrEmpty())
                where = where.And(x => x.ChannelId == ChannelId);
            if (!FeeWay.IsNullOrEmpty())
                where = where.And(x => x.FeeWay == FeeWay);
            if (!IsAd.IsNullOrEmpty())
                where = where.And(x => x.IsAd == IsAd);
            if (!Status.IsNullOrEmpty())
                where = where.And(x => x.Status == Status);
            if (!startTime.IsNullOrEmpty())
                where = where.And(x => x.CreateTime >= startTime);
            if (!endTime.IsNullOrEmpty())
                where = where.And(x => x.CreateTime <= endTime);
            if (!ProductTitle.IsNullOrEmpty())
            {
                where = where.And(x =>
                    x.ProductTitle.Contains(ProductTitle));
            }

            return q.Where(where).GetPagination(pagination).ToList();
        }

        public Dev_Product GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Product newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Product theData)
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