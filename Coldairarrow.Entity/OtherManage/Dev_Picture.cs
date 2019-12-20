using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// 活动图片
    /// </summary>
    [Table("Dev_Picture")]
    public class Dev_Picture
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        public String PictureType { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public String Pic { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public String Link { get; set; }

        /// <summary>
        /// 点击数量
        /// </summary>
        public Int32? ClickNum { get; set; }

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