using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// 商号商讯
    /// </summary>
    [Table("Dev_ShopProduct")]
    public class Dev_ShopProduct
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
        /// 所属商讯
        /// </summary>
        public String ProductId { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public Int32? IsJoin { get; set; }

        /// <summary>
        /// 二维码
        /// </summary>
        public String QrCode { get; set; }

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

        /// <summary>
        /// 排序
        /// </summary>
        public Int32? Sort { get; set; }

    }
}