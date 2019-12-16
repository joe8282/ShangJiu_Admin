using Coldairarrow.Entity.Help;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Help
{
    public interface IDev_HelpTypeBusiness
    {
        List<Dev_HelpType> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_HelpType GetTheData(string id);
        AjaxResult AddData(Dev_HelpType newData);
        AjaxResult UpdateData(Dev_HelpType theData);
        AjaxResult DeleteData(List<string> ids);
    }
}