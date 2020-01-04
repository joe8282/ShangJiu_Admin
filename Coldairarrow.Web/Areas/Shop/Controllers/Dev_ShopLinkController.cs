using Coldairarrow.Business.Shop;
using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Shop.Controllers
{
    public class Dev_ShopLinkController : BaseMvcController
    {
        #region DI

        public Dev_ShopLinkController(IDev_ShopLinkBusiness dev_ShopLinkBus)
        {
            _dev_ShopLinkBus = dev_ShopLinkBus;
        }
        IDev_ShopLinkBusiness _dev_ShopLinkBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_ShopLink() : _dev_ShopLinkBus.GetTheData(id);

            return View(theData);
        }

        #endregion

        #region 获取数据

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(Pagination pagination, string shopId, string linkId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_ShopLinkBus.GetDataList(pagination, false, shopId, linkId, userId, username, keyword, Status, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_ShopLink theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_ShopLinkBus.AddData(theData);
            }
            else
            {
                res = _dev_ShopLinkBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_ShopLinkBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}