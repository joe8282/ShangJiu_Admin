using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.PayRecord
{
    /// <summary>
    /// Dev_PayRecord
    /// </summary>
    [Table("Dev_PayRecord")]
    public class Dev_PayRecord
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ���׺�
        /// </summary>
        public String TradeNo { get; set; }

        /// <summary>
        /// ��¼����
        /// </summary>
        public String RecordType { get; set; }

        /// <summary>
        /// �����̺�
        /// </summary>
        public String ShopId { get; set; }

        /// <summary>
        /// ������Ѷ
        /// </summary>
        public String ProductId { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public Double? Price { get; set; }

        /// <summary>
        /// �����̺Ŵ�����
        /// </summary>
        public String ShopUserrId { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ֧����ʽ
        /// </summary>
        public String PayWay { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// ״̬
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }


    }
}