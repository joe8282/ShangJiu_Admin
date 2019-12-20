using Coldairarrow.Entity.Product;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Product
{
    public interface IDev_ProductBusiness
    {
        List<Dev_Product> GetDataList(Pagination pagination, string condition, string keyword);
        Dev_Product GetTheData(string id);
        AjaxResult AddData(Dev_Product newData);
        AjaxResult UpdateData(Dev_Product theData);
        AjaxResult DeleteData(List<string> ids);
    }
}