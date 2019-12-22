using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopProductBusiness
    {
        List<Dev_ShopProduct> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_ShopProduct GetTheData(string id);
        AjaxResult AddData(Dev_ShopProduct newData);
        AjaxResult UpdateData(Dev_ShopProduct theData);
        AjaxResult DeleteData(List<string> ids);
    }
}