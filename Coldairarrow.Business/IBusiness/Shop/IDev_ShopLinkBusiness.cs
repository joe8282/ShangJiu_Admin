using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopLinkBusiness
    {
        List<Dev_ShopLink> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_ShopLink GetTheData(string id);
        AjaxResult AddData(Dev_ShopLink newData);
        AjaxResult UpdateData(Dev_ShopLink theData);
        AjaxResult DeleteData(List<string> ids);
    }
}