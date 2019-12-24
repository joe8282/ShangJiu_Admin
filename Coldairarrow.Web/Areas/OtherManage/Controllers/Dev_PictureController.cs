using Coldairarrow.Business.OtherManage;
using Coldairarrow.Entity.OtherManage;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.OtherManage.Controllers
{
    public class Dev_PictureController : BaseMvcController
    {
        #region DI

        public Dev_PictureController(IDev_PictureBusiness dev_PictureBus)
        {
            _dev_PictureBus = dev_PictureBus;
        }
        IDev_PictureBusiness _dev_PictureBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Picture() : _dev_PictureBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string PictureType,int? Status,string Title, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_PictureBus.GetDataList(pagination, PictureType, Status, Title, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_Picture theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_PictureBus.AddData(theData);
            }
            else
            {
                res = _dev_PictureBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_PictureBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}