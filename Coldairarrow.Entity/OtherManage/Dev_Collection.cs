using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// 用户关注、商号关注、商号点赞、商讯收藏、商讯点赞、帮助收藏、帮助点赞
    /// </summary>
    [Table("Dev_Collection")]
    public class Dev_Collection
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        public String CollectionType { get; set; }

        /// <summary>
        /// 所属主题ID
        /// </summary>
        public String SubjectId { get; set; }

        /// <summary>
        /// 所属主题标题
        /// </summary>
        public String SubjectTitle { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String UserId { get; set; }

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