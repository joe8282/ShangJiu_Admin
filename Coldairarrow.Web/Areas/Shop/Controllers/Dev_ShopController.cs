using Coldairarrow.Business.Shop;
using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Shop.Controllers
{
    public class Dev_ShopController : BaseMvcController
    {
        #region DI

        public Dev_ShopController(IDev_ShopBusiness dev_ShopBus)
        {
            _dev_ShopBus = dev_ShopBus;
        }
        IDev_ShopBusiness _dev_ShopBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Shop() : _dev_ShopBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string userId, string TypeId, string ClassId, string ChannelId, int? JoinWay, int? IsAd, int? IsTop, int? IsRefresh, int? HasReward, int? Status, string keyword, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_ShopBus.GetDataList(pagination, false, userId, TypeId, ClassId, ChannelId, JoinWay, IsAd, IsTop, IsRefresh, HasReward, Status, keyword, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_Shop theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_ShopBus.AddData(theData);
            }
            else
            {
                res = _dev_ShopBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_ShopBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="status">状态</param>
        /// <param name="remark">备注</param>
        public ActionResult UpdateData(string id, string status, string remark)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Shop() : _dev_ShopBus.GetTheData(id);
            theData.Status = int.Parse(status);
            theData.Remark = remark;
            var res = _dev_ShopBus.UpdateData(theData);

            return JsonContent(res.ToJson());
        }
        #endregion
    }
}