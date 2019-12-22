using Coldairarrow.Entity.AdRecord;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.AdRecord
{
    public interface IDev_AdRecordBusiness
    {
        List<Dev_AdRecord> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_AdRecord GetTheData(string id);
        AjaxResult AddData(Dev_AdRecord newData);
        AjaxResult UpdateData(Dev_AdRecord theData);
        AjaxResult DeleteData(List<string> ids);
    }
}