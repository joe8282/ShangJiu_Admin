using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// �̺�˵˵���̺��ʴ��̺����ԡ���Ѷ���ۡ���������
    /// </summary>
    [Table("Dev_Comment")]
    public class Dev_Comment
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String CommentType { get; set; }

        /// <summary>
        /// ��������ID
        /// </summary>
        public String SubjectId { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public String SubjectTitle { get; set; }

        /// <summary>
        /// �����ϼ�ID
        /// </summary>
        public String ParentId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String CommentContent { get; set; }

        /// <summary>
        /// ͼƬ
        /// </summary>
        public String CommentPic { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

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