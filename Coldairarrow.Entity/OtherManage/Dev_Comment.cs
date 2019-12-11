using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// 商号说说、商号问答、商号留言、商讯评论、帮助评论
    /// </summary>
    [Table("Dev_Comment")]
    public class Dev_Comment
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        public String CommentType { get; set; }

        /// <summary>
        /// 所属主题ID
        /// </summary>
        public String SubjectId { get; set; }

        /// <summary>
        /// 所属主题标题
        /// </summary>
        public String SubjectTitle { get; set; }

        /// <summary>
        /// 所属上级ID
        /// </summary>
        public String ParentId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public String CommentContent { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public String CommentPic { get; set; }

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