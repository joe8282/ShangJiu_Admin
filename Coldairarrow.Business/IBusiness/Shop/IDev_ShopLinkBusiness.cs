using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopLinkBusiness
    {
        List<Dev_ShopLinkDTO> GetDataList(Pagination pagination, bool all, string shopId, string linkId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime);
        Dev_ShopLink GetTheData(string id);
        AjaxResult AddData(Dev_ShopLink newData);
        AjaxResult UpdateData(Dev_ShopLink theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_ShopLinkDTO : Dev_ShopLink
    {
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }

        public string ShopTitle { get; set; }
        public string LinkTitle { get; set; }
    }
}