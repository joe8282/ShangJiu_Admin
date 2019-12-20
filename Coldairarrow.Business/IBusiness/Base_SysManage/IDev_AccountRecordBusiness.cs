using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Base_SysManage
{
    public interface IDev_AccountRecordBusiness
    {
        List<Dev_AccountRecord> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_AccountRecord GetTheData(string id);
        AjaxResult AddData(Dev_AccountRecord newData);
        AjaxResult UpdateData(Dev_AccountRecord theData);
        AjaxResult DeleteData(List<string> ids);
    }
}