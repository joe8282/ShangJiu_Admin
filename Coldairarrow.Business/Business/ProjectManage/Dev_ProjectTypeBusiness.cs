using Coldairarrow.Entity.ProjectManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.ProjectManage
{
    public class Dev_ProjectTypeBusiness : BaseBusiness<Dev_ProjectType>, IDev_ProjectTypeBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_ProjectType> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_ProjectType GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_ProjectType newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_ProjectType theData)
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