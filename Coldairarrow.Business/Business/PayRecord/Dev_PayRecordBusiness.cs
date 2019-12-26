using Coldairarrow.DataRepository;
using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Entity.PayRecord;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Coldairarrow.Business.PayRecord
{
    public class Dev_PayRecordBusiness : BaseBusiness<Dev_PayRecord>, IDev_PayRecordBusiness, IDependency
    {
        private IBaseBusiness<Dev_PayRecord> contentservice = new BaseBusiness<Dev_PayRecord>();
        private IBaseBusiness<Base_User> baseuserservice = new BaseBusiness<Base_User>();

        #region 外部接口

        //public List<Dev_PayRecord_View> GetDataList(Pagination pagination, string condition, string keyword,string RecordType)
        //{

        //    var q=contentservice.GetIQueryable();

        //    //var q=Service.GetIQueryable<Dev_PayRecord_View>();

        //    //筛选
        //    if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
        //        q = q.Where($@"{condition}.Contains(@0)", keyword);

        //    if (!RecordType.IsNullOrEmpty())
        //    {
        //        q = q.Where(t => t.RecordType.Contains(RecordType));
        //    }
        //    return q.GetPagination(pagination).ToList();
        //}

        public List<Dev_PayRecordDTO> GetDataList(Pagination pagination, bool all, string RecordType , string PayWay , int? Status , string TradeNo , string ShopUserrId , string UserName , DateTime? startTime , DateTime? endTime )
        {
            Expression<Func<Dev_PayRecord, Base_User, Dev_PayRecordDTO>> select = (a, b) => new Dev_PayRecordDTO
            {
                UserName = b.UserName,
                RealName=b.RealName
            };
            select = select.BuildExtendSelectExpre();
            var q_PayRecord = all ? Service.GetIQueryable<Dev_PayRecord>() : GetIQueryable();
            var q = from a in q_PayRecord.AsExpandable()
                    join b in Service.GetIQueryable<Base_User>() on a.UserId equals b.Id into ab
                    from b in ab.DefaultIfEmpty()
                    select @select.Invoke(a, b);
            var where = LinqHelper.True<Dev_PayRecordDTO>();
            if (!RecordType.IsNullOrEmpty())
                where = where.And(x => x.RecordType == RecordType);
            if (!PayWay.IsNullOrEmpty())
                where = where.And(x => x.PayWay == PayWay);
            if (!Status.IsNullOrEmpty() && Status>0)
                where = where.And(x => x.Status == Status);
            if (!TradeNo.IsNullOrEmpty())
                where = where.And(x => x.TradeNo == TradeNo);
            if (!ShopUserrId.IsNullOrEmpty())
            {
                var row = baseuserservice.GetDataTableWithSql("select id from Base_User where UserName='" + ShopUserrId + "'");//通过用户输入的username获得用户的id
                string userid;
                if (row.Rows.Count == 0)
                {
                    userid = "";
                }
                else
                {
                    userid = row.Rows[0][0].ToString();
                }
                where = where.And(x => x.ShopUserrId == userid);
            }
            if (!UserName.IsNullOrEmpty())
            {
                var  row = baseuserservice.GetDataTableWithSql("select id from Base_User where UserName='" + UserName + "'");//通过用户输入的username获得用户的id
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
            SetProperty(list);

            return list;

            void SetProperty(List<Dev_PayRecordDTO> PayRecord)
            {
                List<string> PayRecordShopUserrId = PayRecord.Select(x => x.ShopUserrId).ToList();
                var userRoles = (from a in Service.GetIQueryable<Dev_PayRecord>()
                                 join b in Service.GetIQueryable<Base_User>() on a.ShopUserrId equals b.Id
                                 //where PayRecordShopUserrId.Equals(a.UserId)
                                 select new
                                 {
                                     a.ShopUserrId,
                                     b.UserName,
                                     b.RealName
                                 }).ToList();
                PayRecord.ForEach(aUser =>
                {
                    var roleList = userRoles.Where(x => x.ShopUserrId == aUser.ShopUserrId);
                    if (roleList.Select(x => x.UserName).ToList().Count!=0)
                    {
                        aUser.ShopUserrName = roleList.Select(x => x.UserName).ToList()[0].ToString()+"-"+ roleList.Select(x => x.RealName).ToList()[0].ToString(); 
                    }
                    
                });
            }
        }


        public Dev_PayRecord GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_PayRecord newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_PayRecord theData)
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