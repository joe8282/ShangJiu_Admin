using Coldairarrow.Entity.AdRecord;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.AdRecord
{
    public class Dev_AdRecordBusiness : BaseBusiness<Dev_AdRecord>, IDev_AdRecordBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_AdRecord> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
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

        #region ˽�г�Ա

        #endregion

        #region ����ģ��

        #endregion
    }
}