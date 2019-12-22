using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.Shop
{
    public class Dev_ShopMemberBusiness : BaseBusiness<Dev_ShopMember>, IDev_ShopMemberBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_ShopMember> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_ShopMember GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_ShopMember newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_ShopMember theData)
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