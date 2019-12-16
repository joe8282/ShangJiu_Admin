using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.SystemManage
{
    /// <summary>
    /// Dev_Type
    /// </summary>
    [Table("Dev_Type")]
    public class Dev_Type
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 所属上级
        /// </summary>
        public String ParentId { get; set; }

    }
}