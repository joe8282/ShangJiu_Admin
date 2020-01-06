using Coldairarrow.Entity.Product;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.Product
{
    public interface IDev_ProductBusiness
    {
        List<Dev_ProductDTO> GetDataList(Pagination pagination, string TypeId, string ClassId,
            string ChannelId, int? IsAd, int? FeeWay, string UserName, int? Status,
            string ProductTitle, DateTime? startTime, DateTime? endTime);
        Dev_Product GetTheData(string id);
        AjaxResult AddData(Dev_Product newData);
        AjaxResult UpdateData(Dev_Product theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_ProductDTO : Dev_Product
    {
        public string TypeName { get; set; }
        public string ClassName { get; set; }
        public string ChannelName { get; set; }

        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
    }
  }