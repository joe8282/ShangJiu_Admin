using Coldairarrow.Entity.ProjectManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.ProjectManage
{
    public interface IDev_ProjectTypeBusiness
    {
        List<Dev_ProjectType> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_ProjectType GetTheData(string id);
        AjaxResult AddData(Dev_ProjectType newData);
        AjaxResult UpdateData(Dev_ProjectType theData);
        AjaxResult DeleteData(List<string> ids);
    }
}