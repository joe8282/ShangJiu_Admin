using Coldairarrow.Business.Shop;
using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Shop.Controllers
{
    public class Dev_ShopProductController : BaseMvcController
    {
        #region DI

        public Dev_ShopProductController(IDev_ShopProductBusiness dev_ShopProductBus)
        {
            _dev_ShopProductBus = dev_ShopProductBus;
        }
        IDev_ShopProductBusiness _dev_ShopProductBus { get; }

        #endregion

        #region ��ͼ����

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_ShopProduct() : _dev_ShopProductBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string shopId, string productId, string userId, string username, string keyword, int? Status, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_ShopProductBus.GetDataList(pagination, false, shopId, productId, userId, username, keyword, Status, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
        public ActionResult SaveData(Dev_ShopProduct theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_ShopProductBus.AddData(theData);
            }
            else
            {
                res = _dev_ShopProductBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_ShopProductBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}