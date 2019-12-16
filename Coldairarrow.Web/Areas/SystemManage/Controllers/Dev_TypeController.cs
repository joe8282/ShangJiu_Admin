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

        #region ��ͼ����

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

        #region ��ȡ����

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="pagination">��ҳ����</param>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        public ActionResult GetDataList(Pagination pagination, string keyword)
        {
            var dataList = _dev_TypeBus.GetDataList(pagination, keyword);

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

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
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
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_TypeBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}