using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.OtherManage
{
    public interface IDev_CommentBusiness
    {
        List<Dev_CommentDTO> GetDataList(Pagination pagination,
            string userName,
            string commentType,
            int? status,
            string subjectTitle,
            string commentContent,
            DateTime? startTime,
            DateTime? endTime);
        Dev_Comment GetTheData(string id);
        AjaxResult AddData(Dev_Comment newData);
        AjaxResult UpdateData(Dev_Comment theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_CommentDTO : Dev_Comment
    {
        //用户名
        public string UserName { get; set; }
        //真实姓名
        public string RealName { get; set; }
    }
}