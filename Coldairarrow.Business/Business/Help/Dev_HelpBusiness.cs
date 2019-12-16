using Coldairarrow.Entity.Help;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.Help
{
    public class Dev_HelpBusiness : BaseBusiness<Dev_Help>, IDev_HelpBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_Help> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_Help GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Help newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Help theData)
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