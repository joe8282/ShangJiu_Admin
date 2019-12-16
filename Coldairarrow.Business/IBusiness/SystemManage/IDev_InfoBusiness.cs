using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.SystemManage
{
    public interface IDev_InfoBusiness
    {
        List<Dev_InfoDTO> GetDataList(Pagination pagination, 
            string infoType,
            int? status,
            string infoTitle,
            string receiverName,
            DateTime? startTime,
            DateTime? endTime);
        Dev_Info GetTheData(string id);
        AjaxResult AddData(Dev_Info newData);
        AjaxResult UpdateData(Dev_Info theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_InfoDTO : Dev_Info
    {
        //用户名
        public string UserName { get; set; }
        //真实姓名
        public string RealName { get; set; }
    }
}