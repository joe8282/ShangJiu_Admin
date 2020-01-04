using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.AdRecord
{
    /// <summary>
    /// 推广操作表
    /// </summary>
    [Table("Dev_AdOperation")]
    public class Dev_AdOperation
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 所属推广记录
        /// </summary>
        public String AdRecordId { get; set; }

        /// <summary>
        /// 所属推广类型
        /// </summary>
        public String AdRecordType { get; set; }

        /// <summary>
        /// 所属标题ID
        /// </summary>
        public String AboutId { get; set; }

        /// <summary>
        /// 所属标题
        /// </summary>
        public String AboutTitle { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        public String OperationType { get; set; }

        /// <summary>
        /// 天数
        /// </summary>
        public Int32? DateNum { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public String TradeNo { get; set; }

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