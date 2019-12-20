using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.OtherManage
{
    public interface IDev_PictureBusiness
    {
        List<Dev_Picture> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Picture GetTheData(string id);
        AjaxResult AddData(Dev_Picture newData);
        AjaxResult UpdateData(Dev_Picture theData);
        AjaxResult DeleteData(List<string> ids);
    }
}