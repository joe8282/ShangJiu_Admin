using Coldairarrow.Business.Shop;
using Coldairarrow.Entity.Shop;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.Shop.Controllers
{
    public class Dev_ShopController : BaseMvcController
    {
        #region DI

        public Dev_ShopController(IDev_ShopBusiness dev_ShopBus)
        {
            _dev_ShopBus = dev_ShopBus;
        }
        IDev_ShopBusiness _dev_ShopBus { get; }

        #endregion

        #region ��ͼ����

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Dev_Shop() : _dev_ShopBus.GetTheData(id);

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
        public ActionResult GetDataList(Pagination pagination, string userId, string TypeId, string ClassId, string ChannelId, int? JoinWay, int? IsAd, int? IsTop, int? IsRefresh, int? HasReward, int? Status, string keyword, DateTime? startTime, DateTime? endTime)
        {
            var dataList = _dev_ShopBus.GetDataList(pagination, false, userId, TypeId, ClassId, ChannelId, JoinWay, IsAd, IsTop, IsRefresh, HasReward, Status, keyword, startTime, endTime);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
        public ActionResult SaveData(Dev_Shop theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _dev_ShopBus.AddData(theData);
            }
            else
            {
                res = _dev_ShopBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _dev_ShopBus.DeleteData(ids.ToList<string>());

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
            var theData = id.IsNullOrEmpty() ? new Dev_Shop() : _dev_ShopBus.GetTheData(id);
            theData.Status = int.Parse(status);
            theData.Remark = remark;
            var res = _dev_ShopBus.UpdateData(theData);

            return JsonContent(res.ToJson());
        }
        #endregion
    }
}