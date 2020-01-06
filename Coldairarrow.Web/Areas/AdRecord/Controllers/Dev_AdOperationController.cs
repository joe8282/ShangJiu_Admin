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

        #region ��ͼ����

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

        #region ��ȡ����

        /// <summary>
        /// ��ȡ�����б��̺Ų�����
        /// </summary>
        /// <param name="pagination">��ҳ����</param>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        public ActionResult GetDataList(Pagination pagination, string adRecordId, string adRecordType, string operationType, string aboutId, string userId, string username, string keyword, int? Status, DateTime? adTime, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_AdOperationBus.GetDataList(pagination, false, adRecordId, adRecordType, operationType, aboutId, userId, username, keyword, Status, adTime, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
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
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_AdOperationBus.DeleteData(ids.ToList<string>());

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
            var theData = id.IsNullOrEmpty() ? new Dev_AdOperation() : _dev_AdOperationBus.GetTheData(id);
            theData.Status = int.Parse(status);
            theData.Remark = remark;
            var res = _dev_AdOperationBus.UpdateData(theData);

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}