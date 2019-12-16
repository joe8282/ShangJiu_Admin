using Coldairarrow.Business.PayRecord;
using Coldairarrow.Entity.PayRecord;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.PayRecord.Controllers
{
    public class Dev_PayRecordController : BaseMvcController
    {
        #region DI

        public Dev_PayRecordController(IDev_PayRecordBusiness dev_PayRecordBus)
        {
            _dev_PayRecordBus = dev_PayRecordBus;
        }
        IDev_PayRecordBusiness _dev_PayRecordBus { get; }

        #endregion

        #region ��ͼ����

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_PayRecord() : _dev_PayRecordBus.GetTheData(id);

            return View(theData);
        }

        #endregion

        #region ��ȡ����

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="pagination">��ҳ����</param>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        public ActionResult GetDataList(Pagination pagination,string RecordType,string PayWay,int? Status,string TradeNo,string ShopUserrId,string UserName, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_PayRecordBus.GetDataList(pagination, false,  RecordType,PayWay,Status,TradeNo,ShopUserrId,UserName,startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
        public ActionResult SaveData(Dev_PayRecord theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_PayRecordBus.AddData(theData);
            }
            else
            {
                res = _dev_PayRecordBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_PayRecordBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}