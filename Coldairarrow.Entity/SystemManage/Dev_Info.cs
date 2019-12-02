using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.SystemManage
{
    /// <summary>
    /// 消息表
    /// </summary>
    [Table("Dev_Info")]
    public class Dev_Info
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public String InfoType { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        public String InfoTitle { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public String InfoContent { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Int32? Sort { get; set; }

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