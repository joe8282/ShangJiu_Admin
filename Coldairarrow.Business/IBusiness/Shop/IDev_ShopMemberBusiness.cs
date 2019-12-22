using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopMemberBusiness
    {
        List<Dev_ShopMember> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_ShopMember GetTheData(string id);
        AjaxResult AddData(Dev_ShopMember newData);
        AjaxResult UpdateData(Dev_ShopMember theData);
        AjaxResult DeleteData(List<string> ids);
    }
}