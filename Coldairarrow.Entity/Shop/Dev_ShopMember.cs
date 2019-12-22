using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// �̺ų�Ա
    /// </summary>
    [Table("Dev_ShopMember")]
    public class Dev_ShopMember
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
        /// �û�ID
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// �Ƿ����Ա
        /// </summary>
        public Int32? IdAdmin { get; set; }

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