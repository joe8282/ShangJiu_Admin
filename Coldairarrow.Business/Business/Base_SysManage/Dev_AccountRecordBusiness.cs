using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Coldairarrow.Business.Base_SysManage
{
    public class Dev_AccountRecordBusiness : BaseBusiness<Dev_AccountRecord>, IDev_AccountRecordBusiness, IDependency
    {
        private IBaseBusiness<Base_User> baseuserservice = new BaseBusiness<Base_User>();
        #region 外部接口

        public List<Dev_AccountRecordDTO> GetDataList(Pagination pagination, bool all, string RecordType, string RecordClass, int? Status, string UserId, string Remark, DateTime? startTime, DateTime? endTime)
        {
            Expression<Func<Dev_AccountRecord, Base_User, Dev_AccountRecordDTO>> select = (a, b) => new Dev_AccountRecordDTO
            {
                UserName = b.UserName,
                RealName = b.RealName
            };
            select = select.BuildExtendSelectExpre();
            var q_PayRecord = all ? Service.GetIQueryable<Dev_AccountRecord>() : GetIQueryable();
            var q = from a in q_PayRecord.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id into ab
                    from b in ab.DefaultIfEmpty()
                    select @select.Invoke(a, b);
            var where = LinqHelper.True<Dev_AccountRecordDTO>();

            if (!RecordType.IsNullOrEmpty())
                where = where.And(x => x.RecordType == RecordType);
            if (!RecordClass.IsNullOrEmpty())
                where = where.And(x => x.RecordClass == RecordClass);
            if (!Status.IsNullOrEmpty() && Status > 0)
                where = where.And(x => x.Status == Status);
            if (!Remark.IsNullOrEmpty())
                where = where.And(x => x.Remark.Contains(Remark));
            if (!UserId.IsNullOrEmpty())
            {
                var row = baseuserservice.GetDataTableWithSql("select id from Base_User where UserName='" + UserId + "'");//通过用户输入的username获得用户的id
                string userid;
                if (row.Rows.Count == 0)
                {
                    userid = "";
                }
                else
                {
                    userid = row.Rows[0][0].ToString();
                }
                where = where.And(x => x.UserId == userid);
            }

            if (!startTime.IsNullOrEmpty())
            {
                where = where.And(x => x.CreateTime >= startTime);
            }
            if (!endTime.IsNullOrEmpty())
            {
                where = where.And(x => x.CreateTime <= endTime);
            }


            var list = q.Where(where).GetPagination(pagination).ToList();


            return list;
        }

        public Dev_AccountRecord GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_AccountRecord newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_AccountRecord theData)
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