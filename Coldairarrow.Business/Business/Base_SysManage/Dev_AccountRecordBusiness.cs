using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.Base_SysManage
{
    public class Dev_AccountRecordBusiness : BaseBusiness<Dev_AccountRecord>, IDev_AccountRecordBusiness, IDependency
    {
        #region 外部接口

        public List<Dev_AccountRecord> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //筛选
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_AccountRecord GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Dev_AccountRecord newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Dev_AccountRecord theData)
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