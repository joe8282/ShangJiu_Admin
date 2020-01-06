using Coldairarrow.Entity.AdRecord;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.AdRecord
{
    public interface IDev_AdOperationBusiness
    {
        List<Dev_AdOperationDTO> GetDataList(Pagination pagination, bool all, string adRecordId, string adRecordType, string operationType, string aboutId, string userId, string username, string keyword, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime);
        Dev_AdOperation GetTheData(string id);
        AjaxResult AddData(Dev_AdOperation newData);
        AjaxResult UpdateData(Dev_AdOperation theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_AdOperationDTO : Dev_AdOperation
    {
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
    }
}