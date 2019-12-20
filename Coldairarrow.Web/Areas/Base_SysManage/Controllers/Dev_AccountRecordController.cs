using Coldairarrow.Business.Base_SysManage;
using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Base_SysManage.Controllers
{
    public class Dev_AccountRecordController : BaseMvcController
    {
        #region DI

        public Dev_AccountRecordController(IDev_AccountRecordBusiness dev_AccountRecordBus)
        {
            _dev_AccountRecordBus = dev_AccountRecordBus;
        }
        IDev_AccountRecordBusiness _dev_AccountRecordBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_AccountRecord() : _dev_AccountRecordBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string condition, string keyword)
        {
            var dataList = _dev_AccountRecordBus.GetDataList(pagination, condition, keyword);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_AccountRecord theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_AccountRecordBus.AddData(theData);
            }
            else
            {
                res = _dev_AccountRecordBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_AccountRecordBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}