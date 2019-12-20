using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.OtherManage
{
    public class Dev_PictureBusiness : BaseBusiness<Dev_Picture>, IDev_PictureBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_Picture> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_Picture GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Picture newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Picture theData)
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