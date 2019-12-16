using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.Shop
{
    public class Dev_ShopBusiness : BaseBusiness<Dev_Shop>, IDev_ShopBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_Shop> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_Shop GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Shop newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Shop theData)
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