using Coldairarrow.Business.Product;
using Coldairarrow.Entity.Product;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Product.Controllers
{
    public class Dev_ProductController : BaseMvcController
    {
        #region DI

        public Dev_ProductController(IDev_ProductBusiness dev_ProductBus)
        {
            _dev_ProductBus = dev_ProductBus;
        }
        IDev_ProductBusiness _dev_ProductBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Product() : _dev_ProductBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string TypeId, string ClassId, 
            string ChannelId,int? IsAd,int? FeeWay,string UserName,int? Status,
            string ProductTitle, DateTime? StartTime, DateTime? EndTime)
        {
            var dataList = _dev_ProductBus.GetDataList(pagination, TypeId, ClassId, ChannelId, IsAd, FeeWay, UserName, Status, ProductTitle, StartTime, EndTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_Product theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_ProductBus.AddData(theData);
            }
            else
            {
                res = _dev_ProductBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_ProductBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}