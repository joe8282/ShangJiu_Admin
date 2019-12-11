using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// 商号打赏、商讯打赏、帮助打赏
    /// </summary>
    [Table("Dev_Award")]
    public class Dev_Award
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        public String AwardType { get; set; }

        /// <summary>
        /// 所属主题ID
        /// </summary>
        public String SubjectId { get; set; }

        /// <summary>
        /// 所属主题标题
        /// </summary>
        public String SubjectTitle { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public String TradeNo { get; set; }

        /// <summary>
        /// 打赏金额
        /// </summary>
        public Double? AwardFee { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public String CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public String Status { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public String Sort { get; set; }

    }
}