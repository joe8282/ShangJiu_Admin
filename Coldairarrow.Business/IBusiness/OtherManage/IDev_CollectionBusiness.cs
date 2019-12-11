using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.OtherManage
{
    public interface IDev_CollectionBusiness
    {
        List<Dev_Collection> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Collection GetTheData(string id);
        AjaxResult AddData(Dev_Collection newData);
        AjaxResult UpdateData(Dev_Collection theData);
        AjaxResult DeleteData(List<string> ids);
    }
}