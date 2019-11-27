using Coldairarrow.Entity.PayRecord;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.PayRecord
{
    public class Dev_PayRecordBusiness : BaseBusiness<Dev_PayRecord>, IDev_PayRecordBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_PayRecord> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

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

        #region ˽�г�Ա

        #endregion

        #region ����ģ��

        #endregion
    }
}