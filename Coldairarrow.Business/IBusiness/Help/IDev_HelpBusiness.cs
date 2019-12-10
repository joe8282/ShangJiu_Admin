using Coldairarrow.Entity.Help;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Help
{
    public interface IDev_HelpBusiness
    {
        List<Dev_Help> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Help GetTheData(string id);
        AjaxResult AddData(Dev_Help newData);
        AjaxResult UpdateData(Dev_Help theData);
        AjaxResult DeleteData(List<string> ids);
    }
}