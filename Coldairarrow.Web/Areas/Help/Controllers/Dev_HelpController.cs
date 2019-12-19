using Coldairarrow.Business.Help;
using Coldairarrow.Entity.Help;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Help.Controllers
{
    public class Dev_HelpController : BaseMvcController
    {
        #region DI

        public Dev_HelpController(IDev_HelpBusiness dev_HelpBus)
        {
            _dev_HelpBus = dev_HelpBus;
        }
        IDev_HelpBusiness _dev_HelpBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Help() : _dev_HelpBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string TypeId, int? Status,string HelpTitle,DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_HelpBus.GetDataList(pagination,false, TypeId,Status,HelpTitle,startTime,endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_Help theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_HelpBus.AddData(theData);
            }
            else
            {
                res = _dev_HelpBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_HelpBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}