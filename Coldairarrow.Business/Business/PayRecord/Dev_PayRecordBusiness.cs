using Coldairarrow.DataRepository;
using Coldairarrow.Entity.PayRecord;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.PayRecord
{
    public class Dev_PayRecordBusiness : BaseBusiness<Dev_PayRecord>, IDev_PayRecordBusiness, IDependency
    {
        private IBaseBusiness<Dev_PayRecord_View> contentservice = new BaseBusiness<Dev_PayRecord_View>();

        #region 外部接口

        public List<Dev_PayRecord_View> GetDataList(Pagination pagination, string condition, string keyword,string RecordType)
        {

            var q=contentservice.GetIQueryable();

            //var q=Service.GetIQueryable<Dev_PayRecord_View>();

            //筛选
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            if (!RecordType.IsNullOrEmpty())
            {
                q = q.Where(t => t.RecordType.Contains(RecordType));
            }
            return q.GetPagination(pagination).ToList();
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