using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// 商号成员
    /// </summary>
    [Table("Dev_ShopMember")]
    public class Dev_ShopMember
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
        /// 用户ID
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public Int32? IdAdmin { get; set; }

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
        public String Remark { get; set; }

    }
}