using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Shop
{
    public interface IDev_ShopBusiness
    {
        List<Dev_ShopDTO> GetDataList(Pagination pagination, bool all, string userId = null, string TypeId = null, string ClassId = null, string ChannelId = null, string keyword = null);
        Dev_Shop GetTheData(string id);
        AjaxResult AddData(Dev_Shop newData);
        AjaxResult UpdateData(Dev_Shop theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_ShopDTO : Dev_Shop
    {
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }

        public string TypeName { get; set; }
        public string ClassName { get; set; }
        public string ChannelName { get; set; }
    }
}