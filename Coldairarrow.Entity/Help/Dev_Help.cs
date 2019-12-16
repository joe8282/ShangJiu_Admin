using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Help
{
    /// <summary>
    /// ��������
    /// </summary>
    [Table("Dev_Help")]
    public class Dev_Help
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String TypeId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String HelpTitle { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String HelpContent { get; set; }

        /// <summary>
        /// ��ͼ
        /// </summary>
        public String HelpPic { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public Int32? ClickNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? CommentNum { get; set; }

        /// <summary>
        /// �ղ�����
        /// </summary>
        public Int32? CollectNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? GoodNum { get; set; }

        /// <summary>
        /// �����ۼ�
        /// </summary>
        public Double? RewardFee { get; set; }

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