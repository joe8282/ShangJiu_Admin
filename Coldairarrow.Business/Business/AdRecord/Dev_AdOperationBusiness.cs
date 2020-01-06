using Coldairarrow.Entity.AdRecord;
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
    public class Dev_AdOperationBusiness : BaseBusiness<Dev_AdOperation>, IDev_AdOperationBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_AdOperationDTO> GetDataList(Pagination pagination, bool all, string adRecordId, string adRecordType, string operationType, string aboutId, string userId, string username, string keyword, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {

            Expression<Func<Dev_AdOperation, Base_User, Dev_AdOperationDTO>> select = (a, b) => new Dev_AdOperationDTO
            {
                UserName = b.UserName,
                RealName = b.RealName,
                Phone = b.Phone,
            };
            select = select.BuildExtendSelectExpre();
            var q_AdOperation = all ? Service.GetIQueryable<Dev_AdOperation>() : GetIQueryable();
            var q = from a in q_AdOperation.AsExpandable()
                join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id
                select @select.Invoke(a, b);

            var where = LinqHelper.True<Dev_AdOperationDTO>();
            if (!userId.IsNullOrEmpty())
                where = where.And(x => x.UserId == userId);
            if (!adRecordId.IsNullOrEmpty())
                where = where.And(x => x.AdRecordId == adRecordId);
            if (!adRecordType.IsNullOrEmpty())
                where = where.And(x => x.AdRecordType == adRecordType);
            if (!operationType.IsNullOrEmpty())
                where = where.And(x => x.OperationType == operationType);
            if (!aboutId.IsNullOrEmpty())
                where = where.And(x => x.AboutId == aboutId);
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

        public Dev_AdOperation GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_AdOperation newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_AdOperation theData)
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