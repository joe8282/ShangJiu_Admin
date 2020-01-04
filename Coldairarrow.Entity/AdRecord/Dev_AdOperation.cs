using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.AdRecord
{
    /// <summary>
    /// �ƹ������
    /// </summary>
    [Table("Dev_AdOperation")]
    public class Dev_AdOperation
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
        /// �����ƹ��¼
        /// </summary>
        public String AdRecordId { get; set; }

        /// <summary>
        /// �����ƹ�����
        /// </summary>
        public String AdRecordType { get; set; }

        /// <summary>
        /// ��������ID
        /// </summary>
        public String AboutId { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String AboutTitle { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String OperationType { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32? DateNum { get; set; }

        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// ���׺�
        /// </summary>
        public String TradeNo { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }

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