using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// �û���ע���̺Ź�ע���̺ŵ��ޡ���Ѷ�ղء���Ѷ���ޡ������ղء���������
    /// </summary>
    [Table("Dev_Collection")]
    public class Dev_Collection
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String CollectionType { get; set; }

        /// <summary>
        /// ��������ID
        /// </summary>
        public String SubjectId { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public String SubjectTitle { get; set; }

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