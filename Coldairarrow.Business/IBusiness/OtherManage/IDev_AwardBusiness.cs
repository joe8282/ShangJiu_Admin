using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.OtherManage
{
    public interface IDev_AwardBusiness
    {
        List<Dev_AwardDTO> GetDataList(Pagination pagination, string userName,
            string awardType,
            int? status,
            DateTime? startTime,
            DateTime? endTime,
            string subjectTitle);
        Dev_Award GetTheData(string id);
        AjaxResult AddData(Dev_Award newData);
        AjaxResult UpdateData(Dev_Award theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_AwardDTO: Dev_Award
    {
        //用户名
        public string UserName { get; set; }
        //真实姓名
        public string RealName { get; set; }
    }
}