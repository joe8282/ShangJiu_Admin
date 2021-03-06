using Coldairarrow.Business.SystemManage;
using Coldairarrow.Entity.SystemManage;
using Coldairarrow.Util;
using System.Linq;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.SystemManage.Controllers
{
    public class Dev_TypeController : BaseMvcController
    {
        #region DI

        public Dev_TypeController(IDev_TypeBusiness dev_TypeBus)
        {
            _dev_TypeBus = dev_TypeBus;
        }
        IDev_TypeBusiness _dev_TypeBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Type() : _dev_TypeBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string parentId, string keyword)
        {
            var dataList = _dev_TypeBus.GetDataList(pagination, parentId, keyword);

            return DataTable_Bootstrap(dataList, pagination);
        }

        public ActionResult GetDataList_ZTree()
        {
            var dataList = _dev_TypeBus.GetDataList(new Pagination());
            var resList = dataList.Select(x => new
            {
                id = x.Id,
                name = x.Name,
                pId = x.ParentId,
                open = true
            });

            return JsonContent(resList.ToJson());
        }

        /// <summary>
        /// 获取数据列表
        /// 注：无分页
        /// </summary>
        /// <param name="parentId">父级ID</param>
        /// <returns></returns>
        public ActionResult GetDataList_NoPagin(string parentId)
        {
            var dataList = _dev_TypeBus.GetDataList(new Pagination(), parentId);
            return Content(dataList.ToJson());
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Dev_Type theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_TypeBus.AddData(theData);
            }
            else
            {
                res = _dev_TypeBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_TypeBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}