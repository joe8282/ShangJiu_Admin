using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.SystemManage
{
    public class Dev_TypeBusiness : BaseBusiness<Dev_Type>, IDev_TypeBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_Type> GetDataList(Pagination pagination, string parentId = null, string keyword = null)
        {
            var q = GetIQueryable();
            //ɸѡ
            var where = LinqHelper.True<Dev_Type>();
            if (!parentId.IsNullOrEmpty())
                where = where.And(x => x.ParentId == parentId);
            if (!keyword.IsNullOrEmpty())
                where = where.And(x => x.Name.Contains(keyword));

            return q.Where(where).GetPagination(pagination).ToList();
        }

        public Dev_Type GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_Type newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_Type theData)
        {
            Update(theData);

            return Success();
        }

        public AjaxResult DeleteData(List<string> ids)
        {
            if (GetIQueryable().Any(x => ids.Contains(x.ParentId)))
                return Error("��ֹɾ��������ɾ�������Ӽ���");

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