using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.OtherManage
{
    public interface IDev_CommentBusiness
    {
        List<Dev_Comment> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Comment GetTheData(string id);
        AjaxResult AddData(Dev_Comment newData);
        AjaxResult UpdateData(Dev_Comment theData);
        AjaxResult DeleteData(List<string> ids);
    }
}