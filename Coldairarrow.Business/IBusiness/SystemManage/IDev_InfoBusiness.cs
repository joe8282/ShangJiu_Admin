using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.SystemManage
{
    public interface IDev_InfoBusiness
    {
        List<Dev_Info> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Info GetTheData(string id);
        AjaxResult AddData(Dev_Info newData);
        AjaxResult UpdateData(Dev_Info theData);
        AjaxResult DeleteData(List<string> ids);
    }
}