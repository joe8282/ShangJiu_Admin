using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.Base_SysManage
{
    public interface IDev_AccountRecordBusiness
    {
        List<Dev_AccountRecordDTO> GetDataList(Pagination pagination, bool all, string RecordType, string RecordClass, int? Status, string UserId, string Remark, DateTime? startTime, DateTime? endTime);
        Dev_AccountRecord GetTheData(string id);
        AjaxResult AddData(Dev_AccountRecord newData);
        AjaxResult UpdateData(Dev_AccountRecord theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_AccountRecordDTO : Dev_AccountRecord
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }
    }

}