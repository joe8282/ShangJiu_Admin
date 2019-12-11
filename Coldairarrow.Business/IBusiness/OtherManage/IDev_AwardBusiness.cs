using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.OtherManage
{
    public interface IDev_AwardBusiness
    {
        List<Dev_Award> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Award GetTheData(string id);
        AjaxResult AddData(Dev_Award newData);
        AjaxResult UpdateData(Dev_Award theData);
        AjaxResult DeleteData(List<string> ids);
    }
}