using Coldairarrow.Entity.Help;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.Help
{
    public interface IDev_HelpBusiness
    {
        List<Dev_HelpDTO> GetDataList(Pagination pagination, bool all, string TypeId, int? Status, string HelpTitle, DateTime? startTime, DateTime? endTime);
        Dev_Help GetTheData(string id);
        AjaxResult AddData(Dev_Help newData);
        AjaxResult UpdateData(Dev_Help theData);
        AjaxResult DeleteData(List<string> ids);

     

    }

    public class Dev_HelpDTO : Dev_Help
    {
        /// <summary>
        /// ×´Ì¬Ãû³Æ
        /// </summary>
        public string Name { get; set; }

    }
}