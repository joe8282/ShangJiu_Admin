using Coldairarrow.Entity.AdRecord;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.AdRecord
{
    public interface IDev_AdOperationBusiness
    {
        List<Dev_AdOperation> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_AdOperation GetTheData(string id);
        AjaxResult AddData(Dev_AdOperation newData);
        AjaxResult UpdateData(Dev_AdOperation theData);
        AjaxResult DeleteData(List<string> ids);
    }
}