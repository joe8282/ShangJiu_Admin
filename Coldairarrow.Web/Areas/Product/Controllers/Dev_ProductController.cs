using Coldairarrow.Business.Product;
using Coldairarrow.Entity.Product;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Product.Controllers
{
    public class Dev_ProductController : BaseMvcController
    {
        #region DI

        public Dev_ProductController(IDev_ProductBusiness dev_ProductBus)
        {
            _dev_ProductBus = dev_ProductBus;
        }
        IDev_ProductBusiness _dev_ProductBus { get; }

        #endregion

        #region ��ͼ����

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Product() : _dev_ProductBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string TypeId, string ClassId, 
            string ChannelId,int? IsAd,int? FeeWay,string UserName,int? Status,
            string ProductTitle, DateTime? StartTime, DateTime? EndTime)
        {
            var dataList = _dev_ProductBus.GetDataList(pagination, TypeId, ClassId, ChannelId, IsAd, FeeWay, UserName, Status, ProductTitle, StartTime, EndTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
        public ActionResult SaveData(Dev_Product theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_ProductBus.AddData(theData);
            }
            else
            {
                res = _dev_ProductBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_ProductBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}