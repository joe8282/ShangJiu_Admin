using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// 商号
    /// </summary>
    [Table("Dev_Shop")]
    public class Dev_Shop
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 商号标题
        /// </summary>
        public String ShopTitle { get; set; }

        /// <summary>
        /// 商号主图
        /// </summary>
        public String ShopPic { get; set; }

        /// <summary>
        /// 商号摘要
        /// </summary>
        public String ShopRemark { get; set; }

        /// <summary>
        /// 商号介绍
        /// </summary>
        public String ShopContent { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 商号类型
        /// </summary>
        public String TypeId { get; set; }

        /// <summary>
        /// 商号行业
        /// </summary>
        public String ClassId { get; set; }

        /// <summary>
        /// 所有者身份
        /// </summary>
        public String ChannelId { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public String Provice { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public String City { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        public String Area { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public String Contact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public String ContactTel { get; set; }

        /// <summary>
        /// 经营地址
        /// </summary>
        public String ContactAddress { get; set; }

        /// <summary>
        /// 加入方式
        /// </summary>
        public Int32? JoinWay { get; set; }

        /// <summary>
        /// 加入要求
        /// </summary>
        public String JoinDemand { get; set; }

        /// <summary>
        /// 加入费用（按次）
        /// </summary>
        public Double? JoinFeeOnce { get; set; }

        /// <summary>
        /// 加入费用（按月）
        /// </summary>
        public Double? JoinFeeMonth { get; set; }

        /// <summary>
        /// 加入费用（按年）
        /// </summary>
        public Double? JoinFeeYear { get; set; }

        /// <summary>
        /// 加入费用（不限）
        /// </summary>
        public Double? JoinFeeUnlimited { get; set; }

        /// <summary>
        /// 是否推广
        /// </summary>
        public Int32? IsAd { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public Int32? IsTop { get; set; }

        /// <summary>
        /// 是否自刷
        /// </summary>
        public Int32? IsRefresh { get; set; }

        /// <summary>
        /// 有无红包
        /// </summary>
        public Int32? HasReward { get; set; }

        /// <summary>
        /// 推广支出
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// 红包支出
        /// </summary>
        public Double? RewardFee { get; set; }

        /// <summary>
        /// 成员数量
        /// </summary>
        public Int32? MemberNum { get; set; }

        /// <summary>
        /// 商讯数量
        /// </summary>
        public Int32? ProductNum { get; set; }

        /// <summary>
        /// 商链数量
        /// </summary>
        public Int32? LinkNum { get; set; }

        /// <summary>
        /// 说说数量
        /// </summary>
        public Int32? ChatNum { get; set; }

        /// <summary>
        /// 问答数量
        /// </summary>
        public Int32? AskNum { get; set; }

        /// <summary>
        /// 留言数量
        /// </summary>
        public Int32? MessageNum { get; set; }

        /// <summary>
        /// 代理数量
        /// </summary>
        public Int32? AgentNum { get; set; }

        /// <summary>
        /// 托客数量
        /// </summary>
        public Int32? CustomerNum { get; set; }

        /// <summary>
        /// 收费累计
        /// </summary>
        public Double? GetPayFee { get; set; }

        /// <summary>
        /// 打赏累计
        /// </summary>
        public Double? GetRewardFee { get; set; }

        /// <summary>
        /// 浏览数量
        /// </summary>
        public Int32? ClickNum { get; set; }

        /// <summary>
        /// 关注数量
        /// </summary>
        public Int32? CollectionNum { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        public Int32? GoodNum { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? StatusTime { get; set; }

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