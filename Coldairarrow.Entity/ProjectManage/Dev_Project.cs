using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.ProjectManage
{
    /// <summary>
    /// ��Ŀ��
    /// </summary>
    [Table("Dev_Project")]
    public class Dev_Project
    {

        /// <summary>
        /// ��Ȼ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��ĿId
        /// </summary>
        public String ProjectId { get; set; }

        /// <summary>
        /// ��Ŀ��
        /// </summary>
        public String ProjectName { get; set; }

        /// <summary>
        /// ��Ŀ����Id
        /// </summary>
        public String ProjectTypeId { get; set; }

        /// <summary>
        /// ��Ŀ����Id
        /// </summary>
        public String ProjectManagerId { get; set; }


        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public String ProjectContent { get; set; }

        /// <summary>
        /// ��Ŀ��ע
        /// </summary>
        public String ProjectRemark { get; set; }

    }
}