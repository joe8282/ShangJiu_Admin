using Coldairarrow.Entity.Product;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.Product
{
    public class Dev_ProductBusiness : BaseBusiness<Dev_Product>, IDev_ProductBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_Product> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_Product GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Product newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Product theData)
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