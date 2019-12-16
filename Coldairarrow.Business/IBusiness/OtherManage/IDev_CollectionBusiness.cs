using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.OtherManage
{
    public interface IDev_CollectionBusiness
    {
        List<Dev_CollectionDTO> GetDataList(Pagination pagination, string userName,
            string collectionType,
            int? status,
            string subjectTitle,
            DateTime? startTime,
            DateTime? endTime);
        Dev_Collection GetTheData(string id);
        AjaxResult AddData(Dev_Collection newData);
        AjaxResult UpdateData(Dev_Collection theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_CollectionDTO : Dev_Collection
    {
        //用户名
        public string UserName { get; set; }
        //真实姓名
        public string RealName { get; set; }
    }
}