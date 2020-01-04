using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.AdRecord
{
    /// <summary>
    /// �ƹ��¼��
    /// </summary>
    [Table("Dev_AdRecord")]
    public class Dev_AdRecord
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ��¼����
        /// </summary>
        public String RecordType { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public String AboutId { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String AboutTitle { get; set; }

        /// <summary>
        /// �ƹ�ʡ��
        /// </summary>
        public String AdProvice { get; set; }

        /// <summary>
        /// �ƹ����
        /// </summary>
        public String AdCity { get; set; }

        /// <summary>
        /// �ƹ�����
        /// </summary>
        public String AdArea { get; set; }

        /// <summary>
        /// �ƹ�����
        /// </summary>
        public Int32? AdDateNum { get; set; }

        /// <summary>
        /// �ƹ����
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// ���׺�
        /// </summary>
        public String TradeNo { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String PayWay { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// �ƹ㿪ʼʱ��
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// �ƹ����ʱ��
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// �Ƿ��ö�
        /// </summary>
        public Int32? IsTop { get; set; }

        /// <summary>
        /// �Ƿ���ˢ
        /// </summary>
        public Int32? IsRefresh { get; set; }

        /// <summary>
        /// �Ƿ���ˢ
        /// </summary>
        public Int32? IsRefreshUser { get; set; }

        /// <summary>
        /// ״̬
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String Remark { get; set; }

    }
}