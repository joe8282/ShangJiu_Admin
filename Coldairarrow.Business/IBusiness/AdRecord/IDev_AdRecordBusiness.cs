using Coldairarrow.Entity.AdRecord;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.AdRecord
{
    public interface IDev_AdRecordBusiness
    {
        List<Dev_AdRecordDTO> GetDataList(Pagination pagination, bool all,  int typeId, string aboutId, string userId, string username, string keyword, int? IsTop, int? IsRefresh, int? IsRefreshUser, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime);
        Dev_AdRecord GetTheData(string id);
        AjaxResult AddData(Dev_AdRecord newData);
        AjaxResult UpdateData(Dev_AdRecord theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_AdRecordDTO : Dev_AdRecord
    {
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
    }
}