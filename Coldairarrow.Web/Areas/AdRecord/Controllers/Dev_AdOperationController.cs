using Coldairarrow.Business.AdRecord;
using Coldairarrow.Entity.AdRecord;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.AdRecord.Controllers
{
    public class Dev_AdOperationController : BaseMvcController
    {
        #region DI

        public Dev_AdOperationController(IDev_AdOperationBusiness dev_AdOperationBus)
        {
            _dev_AdOperationBus = dev_AdOperationBus;
        }
        IDev_AdOperationBusiness _dev_AdOperationBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_AdOperation() : _dev_AdOperationBus.GetTheData(id);

            return View(theData);
        }

        #endregion

        #region 获取数据

        /// <summary>
        /// 获取数据列表（商号操作）
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(Pagination pagination, string adRecordId, string adRecordType, string operationType, string aboutId, string userId, string username, string keyword, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_AdOperationBus.GetDataList(pagination, false, adRecordId, adRecordType, operationType, aboutId, userId, username, keyword, Status, adTime, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_AdOperation theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_AdOperationBus.AddData(theData);
            }
            else
            {
                res = _dev_AdOperationBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_AdOperationBus.DeleteData(ids.ToList<string>());

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
            var theData = id.IsNullOrEmpty() ? new Dev_AdOperation() : _dev_AdOperationBus.GetTheData(id);
            theData.Status = int.Parse(status);
            theData.Remark = remark;
            var res = _dev_AdOperationBus.UpdateData(theData);

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}