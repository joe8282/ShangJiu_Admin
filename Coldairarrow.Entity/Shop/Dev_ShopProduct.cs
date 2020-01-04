using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// �̺���Ѷ
    /// </summary>
    [Table("Dev_ShopProduct")]
    public class Dev_ShopProduct
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// �����̺�
        /// </summary>
        public String ShopId { get; set; }

        /// <summary>
        /// �����û�
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ������Ѷ
        /// </summary>
        public String ProductId { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public Int32? IsJoin { get; set; }

        /// <summary>
        /// ��ά��
        /// </summary>
        public String QrCode { get; set; }

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

        /// <summary>
        /// ����
        /// </summary>
        public Int32? Sort { get; set; }

    }
}