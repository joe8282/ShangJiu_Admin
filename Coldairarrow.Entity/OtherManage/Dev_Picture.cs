using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// �ͼƬ
    /// </summary>
    [Table("Dev_Picture")]
    public class Dev_Picture
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String PictureType { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// ͼƬ
        /// </summary>
        public String Pic { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Link { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public Int32? ClickNum { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// ״̬
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32? Sort { get; set; }

    }
}