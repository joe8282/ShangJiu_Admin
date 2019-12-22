using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// 商号链入表
    /// </summary>
    [Table("Dev_ShopLink")]
    public class Dev_ShopLink
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 所属商号
        /// </summary>
        public String ShopId { get; set; }

        /// <summary>
        /// 所属用户
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 链入商号
        /// </summary>
        public String LinkId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Ramark { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Int32? Sort { get; set; }

    }
}