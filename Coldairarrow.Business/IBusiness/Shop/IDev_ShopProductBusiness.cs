using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopProductBusiness
    {
        List<Dev_ShopProductDTO> GetDataList(Pagination pagination, bool all, string shopId, string productId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime);
        Dev_ShopProduct GetTheData(string id);
        AjaxResult AddData(Dev_ShopProduct newData);
        AjaxResult UpdateData(Dev_ShopProduct theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_ShopProductDTO : Dev_ShopProduct
    {
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }

        public string ShopTitle { get; set; }
        public string ProductTitle { get; set; }
    }
}