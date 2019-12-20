using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Base_SysManage
{
    /// <summary>
    /// �˻����׼�¼
    /// </summary>
    [Table("Dev_AccountRecord")]
    public class Dev_AccountRecord
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��¼����
        /// </summary>
        public String RecordType { get; set; }

        /// <summary>
        /// ��¼��ʶ
        /// </summary>
        public String RecordClass { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public String AboutId { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public Double? Price { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// ״̬
        /// </summary>
        public Int32? Status { get; set; }

    }
}