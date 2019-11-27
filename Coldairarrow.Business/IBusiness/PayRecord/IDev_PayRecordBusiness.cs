using Coldairarrow.Entity.PayRecord;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.PayRecord
{
    public interface IDev_PayRecordBusiness
    {
        List<Dev_PayRecord> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_PayRecord GetTheData(string id);
        AjaxResult AddData(Dev_PayRecord newData);
        AjaxResult UpdateData(Dev_PayRecord theData);
        AjaxResult DeleteData(List<string> ids);
    }
}