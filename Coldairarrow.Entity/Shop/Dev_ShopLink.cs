using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// �̺������
    /// </summary>
    [Table("Dev_ShopLink")]
    public class Dev_ShopLink
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
        /// �����̺�
        /// </summary>
        public String LinkId { get; set; }

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
        public String Ramark { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32? Sort { get; set; }

    }
}