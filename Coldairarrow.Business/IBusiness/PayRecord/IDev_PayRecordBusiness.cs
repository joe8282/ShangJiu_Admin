using Coldairarrow.Entity.PayRecord;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.PayRecord
{
    public interface IDev_PayRecordBusiness
    {
        //List<Dev_PayRecord_View> GetDataList(Pagination pagination, string condition, string keyword, string RecordType);

        List<Dev_PayRecordDTO> GetDataList(Pagination pagination, bool all, string RecordType , string PayWay , int? Status, string TradeNo , string ShopUserrId , string UserName , DateTime? startTime , DateTime? endTime );
        Dev_PayRecord GetTheData(string id);
        AjaxResult AddData(Dev_PayRecord newData);
        AjaxResult UpdateData(Dev_PayRecord theData);
        AjaxResult DeleteData(List<string> ids);
    }

    public class Dev_PayRecordDTO : Dev_PayRecord
    {
        /// <summary>
        /// �û���
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// ��ʵ����
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// �����̺Ŵ���������
        /// </summary>
        public string ShopUserrName { get; set; }
    }
}