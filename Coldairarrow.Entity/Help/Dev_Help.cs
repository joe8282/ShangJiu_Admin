using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Help
{
    /// <summary>
    /// 帮助中心
    /// </summary>
    [Table("Dev_Help")]
    public class Dev_Help
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        public String TypeId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public String HelpTitle { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public String HelpContent { get; set; }

        /// <summary>
        /// 主图
        /// </summary>
        public String HelpPic { get; set; }

        /// <summary>
        /// 浏览数量
        /// </summary>
        public Int32? ClickNum { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        public Int32? CommentNum { get; set; }

        /// <summary>
        /// 收藏数量
        /// </summary>
        public Int32? CollectNum { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        public Int32? GoodNum { get; set; }

        /// <summary>
        /// 打赏累计
        /// </summary>
        public Double? RewardFee { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Int32? Sort { get; set; }

    }
}