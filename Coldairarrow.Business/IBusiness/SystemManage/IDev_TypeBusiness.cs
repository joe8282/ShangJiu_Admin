using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.SystemManage
{
    public interface IDev_TypeBusiness
    {
        List<Dev_Type> GetDataList(Pagination pagination, string parentId = null, string keyword = null);
        Dev_Type GetTheData(string id);
        AjaxResult AddData(Dev_Type newData);
        AjaxResult UpdateData(Dev_Type theData);
        AjaxResult DeleteData(List<string> ids);
    }
}