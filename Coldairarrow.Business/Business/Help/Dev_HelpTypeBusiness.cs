using Coldairarrow.Entity.Help;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.Help
{
    public class Dev_HelpTypeBusiness : BaseBusiness<Dev_HelpType>, IDev_HelpTypeBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_HelpType> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //筛选
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_HelpType GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_HelpType newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_HelpType theData)
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