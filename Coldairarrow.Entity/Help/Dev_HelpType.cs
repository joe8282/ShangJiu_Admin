using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Help
{
    /// <summary>
    /// 帮助中心分类
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
        /// 类型名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Int32? Sort { get; set; }

    }
}