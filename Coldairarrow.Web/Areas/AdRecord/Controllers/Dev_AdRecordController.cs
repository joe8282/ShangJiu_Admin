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

        #region ��ͼ����

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

        #region ��ȡ����

        /// <summary>
        /// ��ȡ�����б��̺��ƹ㣩
        /// </summary>
        /// <param name="pagination">��ҳ����</param>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        public ActionResult GetDataList1(Pagination pagination, string aboutId, string userId, string username, string keyword, int? IsTop, int? IsRefresh, int? IsRefreshUser, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_AdRecordBus.GetDataList(pagination, false, 1, aboutId, userId, username, keyword, IsTop, IsRefresh, IsRefreshUser, Status, adTime, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        /// <summary>
        /// ��ȡ�����б���Ѷ�ƹ㣩
        /// </summary>
        /// <param name="pagination">��ҳ����</param>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        public ActionResult GetDataList2(Pagination pagination, string aboutId, string userId, string username, string keyword, int? IsTop, int? IsRefresh, int? IsRefreshUser, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_AdRecordBus.GetDataList(pagination, false, 2, aboutId, userId, username, keyword, IsTop, IsRefresh, IsRefreshUser, Status, adTime, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
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
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_AdRecordBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// ����״̬
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="status">״̬</param>
        /// <param name="remark">��ע</param>
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