using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.OtherManage
{
    /// <summary>
    /// �̺Ŵ��͡���Ѷ���͡���������
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
        /// ��������
        /// </summary>
        public String AwardType { get; set; }

        /// <summary>
        /// ��������ID
        /// </summary>
        public String SubjectId { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public String SubjectTitle { get; set; }

        /// <summary>
        /// ���׺�
        /// </summary>
        public String TradeNo { get; set; }

        /// <summary>
        /// ���ͽ��
        /// </summary>
        public Double? AwardFee { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public String CreateTime { get; set; }

        /// <summary>
        /// ״̬
        /// </summary>
        public String Status { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Sort { get; set; }

    }
}