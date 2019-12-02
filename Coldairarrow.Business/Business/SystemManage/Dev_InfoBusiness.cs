using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.SystemManage
{
    public class Dev_InfoBusiness : BaseBusiness<Dev_Info>, IDev_InfoBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_Info> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //筛选
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

        #region 私有成员

        #endregion

        #region 数据模型

        #endregion
    }
}