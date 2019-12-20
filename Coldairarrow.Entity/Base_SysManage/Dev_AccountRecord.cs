using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Base_SysManage
{
    /// <summary>
    /// 账户交易记录
    /// </summary>
    [Table("Dev_AccountRecord")]
    public class Dev_AccountRecord
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        public String RecordType { get; set; }

        /// <summary>
        /// 记录标识
        /// </summary>
        public String RecordClass { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 关联ID
        /// </summary>
        public String AboutId { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public Double? Price { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Int32? Status { get; set; }

    }
}