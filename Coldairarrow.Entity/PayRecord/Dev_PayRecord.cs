using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.PayRecord
{
    /// <summary>
    /// Dev_PayRecord
    /// </summary>
    [Table("Dev_PayRecord")]
    public class Dev_PayRecord
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public String TradeNo { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        public String RecordType { get; set; }

        /// <summary>
        /// 付款商号
        /// </summary>
        public String ShopId { get; set; }

        /// <summary>
        /// 付款商讯
        /// </summary>
        public String ProductId { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public Double? Price { get; set; }

        /// <summary>
        /// 付款商号创建人
        /// </summary>
        public String ShopUserrId { get; set; }

        /// <summary>
        /// 付款人
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public String PayWay { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }


    }
}