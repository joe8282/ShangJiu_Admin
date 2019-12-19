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

        #region ��ͼ����

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

        #region ��ȡ����

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="pagination">��ҳ����</param>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        public ActionResult GetDataList(Pagination pagination, string TypeId, int? Status,string HelpTitle,DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_HelpBus.GetDataList(pagination,false, TypeId,Status,HelpTitle,startTime,endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
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
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_HelpBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}