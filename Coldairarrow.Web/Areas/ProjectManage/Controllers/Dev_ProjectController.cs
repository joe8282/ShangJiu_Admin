using Coldairarrow.Business.ProjectManage;
using Coldairarrow.Entity.ProjectManage;
using Coldairarrow.Util;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.ProjectManage.Controllers
{
    public class Dev_ProjectController : BaseMvcController
    {
        #region DI

        public Dev_ProjectController(IDev_ProjectBusiness dev_ProjectBus)
        {
            _dev_ProjectBus = dev_ProjectBus;
        }
        IDev_ProjectBusiness _dev_ProjectBus { get; }

        #endregion

        #region ��ͼ����

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Project() : _dev_ProjectBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string condition, string keyword)
        {
            var dataList = _dev_ProjectBus.GetDataList(pagination, condition, keyword);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
        public ActionResult SaveData(Dev_Project theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_ProjectBus.AddData(theData);
            }
            else
            {
                res = _dev_ProjectBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_ProjectBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}