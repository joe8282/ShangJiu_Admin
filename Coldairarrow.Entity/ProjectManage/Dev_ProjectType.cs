using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.ProjectManage
{
    /// <summary>
    /// ��Ŀ���ͱ�
    /// </summary>
    [Table("Dev_ProjectType")]
    public class Dev_ProjectType
    {

        /// <summary>
        /// ��Ȼ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��Ŀ����Id
        /// </summary>
        public String ProjectTypeId { get; set; }

        /// <summary>
        /// ��Ŀ������
        /// </summary>
        public String ProjectTypeName { get; set; }

    }
}