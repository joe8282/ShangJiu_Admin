using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.SystemManage
{
    /// <summary>
    /// ��Ϣ��
    /// </summary>
    [Table("Dev_Info")]
    public class Dev_Info
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public String InfoType { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public String InfoTitle { get; set; }

        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public String InfoContent { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32? Sort { get; set; }

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