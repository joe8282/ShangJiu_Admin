using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Product
{
    /// <summary>
    /// 商讯
    /// </summary>
    [Table("Dev_Product")]
    public class Dev_Product
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 商讯标题
        /// </summary>
        public String ProductTitle { get; set; }

        /// <summary>
        /// 商讯主图
        /// </summary>
        public String ProductPic { get; set; }

        /// <summary>
        /// 商讯摘要
        /// </summary>
        public String ProductRemark { get; set; }

        /// <summary>
        /// 商讯内容
        /// </summary>
        public String ProductContent { get; set; }

        /// <summary>
        /// 所属商号
        /// </summary>
        public String ShopId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        public String TypeId { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        public String ClassId { get; set; }

        /// <summary>
        /// 所属应用
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
        /// 收费设置
        /// </summary>
        public Int32? FeeWay { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        public Double? PayFee { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public String FromWay { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public String Author { get; set; }

        /// <summary>
        /// 出处
        /// </summary>
        public String Source { get; set; }

        /// <summary>
        /// 是否推广
        /// </summary>
        public Int32? IsAd { get; set; }

        /// <summary>
        /// 推广支出
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        public Int32? CommentNum { get; set; }

        /// <summary>
        /// 浏览数量
        /// </summary>
        public Int32? ClickNum { get; set; }

        /// <summary>
        /// 收藏数量
        /// </summary>
        public Int32? CollectionNum { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        public Int32? GoodNum { get; set; }

        /// <summary>
        /// 收费累计
        /// </summary>
        public Double? GetPayFee { get; set; }

        /// <summary>
        /// 打赏累计
        /// </summary>
        public Double? GetRewardFee { get; set; }

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
        /// 排序
        /// </summary>
        public Int32? Sort { get; set; }

    }
}