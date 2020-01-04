using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopMemberBusiness
    {
        List<Dev_ShopMemberDTO> GetDataList(Pagination pagination, bool all, string shopId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime);
        Dev_ShopMember GetTheData(string id);
        AjaxResult AddData(Dev_ShopMember newData);
        AjaxResult UpdateData(Dev_ShopMember theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_ShopMemberDTO : Dev_ShopMember
    {
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }

        public string ShopTitle { get; set; }
    }
}