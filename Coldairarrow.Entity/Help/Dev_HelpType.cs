using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Help
{
    /// <summary>
    /// �������ķ���
    /// </summary>
    [Table("Dev_HelpType")]
    public class Dev_HelpType
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32? Sort { get; set; }

    }
}