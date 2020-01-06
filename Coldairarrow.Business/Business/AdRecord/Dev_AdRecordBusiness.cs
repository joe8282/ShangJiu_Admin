using Coldairarrow.Entity.AdRecord;
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

namespace Coldairarrow.Business.AdRecord
{
    public class Dev_AdRecordBusiness : BaseBusiness<Dev_AdRecord>, IDev_AdRecordBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_AdRecordDTO> GetDataList(Pagination pagination, bool all, int typeId, string aboutId, string userId, string username, string keyword, int? IsTop, int? IsRefresh, int? IsRefreshUser, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {
            IQueryable<Dev_AdRecordDTO> q = null;

            //商号推广
            if (typeId == 1)
            {
                Expression<Func<Dev_AdRecord, Base_User, Dev_Shop, Dev_AdRecordDTO>> select = (a, b, c) => new Dev_AdRecordDTO
                {
                    UserName = b.UserName,
                    RealName = b.RealName,
                    Phone = b.Phone,
                    AboutTitle = c.ShopTitle,
                };
                select = select.BuildExtendSelectExpre();
                var q_AdRecord = all ? Service.GetIQueryable<Dev_AdRecord>() : GetIQueryable();
                q = from a in q_AdRecord.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                    join c in Service.GetIQueryable<Dev_Shop>() on a.AboutId equals c.Id
                    select @select.Invoke(a, b, c);
            }
            //商讯推广
            if (typeId == 2)
            {
                Expression<Func<Dev_AdRecord, Base_User, Dev_Product, Dev_AdRecordDTO>> select = (a, b, c) => new Dev_AdRecordDTO
                {
                    UserName = b.UserName,
                    RealName = b.RealName,
                    Phone = b.Phone,
                    AboutTitle = c.ProductTitle,
                };
                select = select.BuildExtendSelectExpre();
                var q_AdRecord = all ? Service.GetIQueryable<Dev_AdRecord>() : GetIQueryable();
                q = from a in q_AdRecord.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                    join c in Service.GetIQueryable<Dev_Product>() on a.AboutId equals c.Id
                    select @select.Invoke(a, b, c);
            }

            var where = LinqHelper.True<Dev_AdRecordDTO>();
            if (!userId.IsNullOrEmpty())
                where = where.And(x => x.UserId == userId);
            if (!aboutId.IsNullOrEmpty())
                where = where.And(x => x.AboutId == aboutId);
            if (!IsTop.IsNullOrEmpty())
                where = where.And(x => x.IsTop == IsTop);
            if (!IsRefresh.IsNullOrEmpty())
                where = where.And(x => x.IsRefresh == IsRefresh);
            if (!IsRefreshUser.IsNullOrEmpty())
                where = where.And(x => x.IsRefreshUser == IsRefreshUser);
            if (!Status.IsNullOrEmpty())
                where = where.And(x => x.Status == Status);
            if (!startTime.IsNullOrEmpty())
                where = where.And(x => DbFunctions.TruncateTime(x.CreateTime) >= startTime);
            if (!endTime.IsNullOrEmpty())
                where = where.And(x => DbFunctions.TruncateTime(x.CreateTime) <= endTime);
            if (!adTime.IsNullOrEmpty())
                where = where.And(x => DbFunctions.TruncateTime(x.StartTime) <= adTime && DbFunctions.TruncateTime(x.EndTime) >= adTime);
            if (!keyword.IsNullOrEmpty())
                where = where.And(x => x.AboutTitle.Contains(keyword));
            if (!username.IsNullOrEmpty())
            {
                where = where.And(x =>
                    x.UserName.Contains(username)
                    || x.RealName.Contains(username)
                    || x.Phone.Contains(username));
            }

            return q.Where(where).GetPagination(pagination).ToList();
        }

        public Dev_AdRecord GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_AdRecord newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_AdRecord theData)
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