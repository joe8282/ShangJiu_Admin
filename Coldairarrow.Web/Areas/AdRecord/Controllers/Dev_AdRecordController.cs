using Coldairarrow.Business.AdRecord;
using Coldairarrow.Entity.AdRecord;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.AdRecord.Controllers
{
    public class Dev_AdRecordController : BaseMvcController
    {
        #region DI

        public Dev_AdRecordController(IDev_AdRecordBusiness dev_AdRecordBus)
        {
            _dev_AdRecordBus = dev_AdRecordBus;
        }
        IDev_AdRecordBusiness _dev_AdRecordBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_AdRecord() : _dev_AdRecordBus.GetTheData(id);

            return View(theData);
        }

        #endregion

        #region 获取数据

        /// <summary>
        /// 获取数据列表（商号推广）
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList1(Pagination pagination, string aboutId, string userId, string username, string keyword, int? IsTop, int? IsRefresh, int? IsRefreshUser, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_AdRecordBus.GetDataList(pagination, false, 1, aboutId, userId, username, keyword, IsTop, IsRefresh, IsRefreshUser, Status, adTime, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        /// <summary>
        /// 获取数据列表（商讯推广）
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList2(Pagination pagination, string aboutId, string userId, string username, string keyword, int? IsTop, int? IsRefresh, int? IsRefreshUser, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_AdRecordBus.GetDataList(pagination, false, 2, aboutId, userId, username, keyword, IsTop, IsRefresh, IsRefreshUser, Status, adTime, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_AdRecord theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_AdRecordBus.AddData(theData);
            }
            else
            {
                res = _dev_AdRecordBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_AdRecordBus.DeleteData(ids.ToList<string>());

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
            var theData = id.IsNullOrEmpty() ? new Dev_AdRecord() : _dev_AdRecordBus.GetTheData(id);
            theData.Status = int.Parse(status);
            theData.Remark = remark;
            var res = _dev_AdRecordBus.UpdateData(theData);

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}