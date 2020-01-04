using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.AdRecord
{
    /// <summary>
    /// 推广记录表
    /// </summary>
    [Table("Dev_AdRecord")]
    public class Dev_AdRecord
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
        /// 记录类型
        /// </summary>
        public String RecordType { get; set; }

        /// <summary>
        /// 所属ID
        /// </summary>
        public String AboutId { get; set; }

        /// <summary>
        /// 所属标题
        /// </summary>
        public String AboutTitle { get; set; }

        /// <summary>
        /// 推广省份
        /// </summary>
        public String AdProvice { get; set; }

        /// <summary>
        /// 推广城市
        /// </summary>
        public String AdCity { get; set; }

        /// <summary>
        /// 推广区县
        /// </summary>
        public String AdArea { get; set; }

        /// <summary>
        /// 推广天数
        /// </summary>
        public Int32? AdDateNum { get; set; }

        /// <summary>
        /// 推广费用
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public String TradeNo { get; set; }

        /// <summary>
        /// 付款类型
        /// </summary>
        public String PayWay { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 推广开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 推广结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public Int32? IsTop { get; set; }

        /// <summary>
        /// 是否自刷
        /// </summary>
        public Int32? IsRefresh { get; set; }

        /// <summary>
        /// 是否手刷
        /// </summary>
        public Int32? IsRefreshUser { get; set; }

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