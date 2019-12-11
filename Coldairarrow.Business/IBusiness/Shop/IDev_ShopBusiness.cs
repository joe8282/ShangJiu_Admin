using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopBusiness
    {
        List<Dev_Shop> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Shop GetTheData(string id);
        AjaxResult AddData(Dev_Shop newData);
        AjaxResult UpdateData(Dev_Shop theData);
        AjaxResult DeleteData(List<string> ids);
    }
}