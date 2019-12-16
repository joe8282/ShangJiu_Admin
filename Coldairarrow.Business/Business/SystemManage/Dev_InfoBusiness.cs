using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.SystemManage
{
    public class Dev_InfoBusiness : BaseBusiness<Dev_Info>, IDev_InfoBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_Info> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_Info GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Info newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Info theData)
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