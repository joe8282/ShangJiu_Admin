using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Product
{
    /// <summary>
    /// ��Ѷ
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
        /// ��Ѷ����
        /// </summary>
        public String ProductTitle { get; set; }

        /// <summary>
        /// ��Ѷ��ͼ
        /// </summary>
        public String ProductPic { get; set; }

        /// <summary>
        /// ��ѶժҪ
        /// </summary>
        public String ProductRemark { get; set; }

        /// <summary>
        /// ��Ѷ����
        /// </summary>
        public String ProductContent { get; set; }

        /// <summary>
        /// �����̺�
        /// </summary>
        public String ShopId { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String TypeId { get; set; }

        /// <summary>
        /// ������ҵ
        /// </summary>
        public String ClassId { get; set; }

        /// <summary>
        /// ����Ӧ��
        /// </summary>
        public String ChannelId { get; set; }

        /// <summary>
        /// ʡ��
        /// </summary>
        public String Provice { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String City { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Area { get; set; }

        /// <summary>
        /// �շ�����
        /// </summary>
        public Int32? FeeWay { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Double? PayFee { get; set; }

        /// <summary>
        /// ��Դ
        /// </summary>
        public String FromWay { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Author { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Source { get; set; }

        /// <summary>
        /// �Ƿ��ƹ�
        /// </summary>
        public Int32? IsAd { get; set; }

        /// <summary>
        /// �ƹ�֧��
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? CommentNum { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public Int32? ClickNum { get; set; }

        /// <summary>
        /// �ղ�����
        /// </summary>
        public Int32? CollectionNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? GoodNum { get; set; }

        /// <summary>
        /// �շ��ۼ�
        /// </summary>
        public Double? GetPayFee { get; set; }

        /// <summary>
        /// �����ۼ�
        /// </summary>
        public Double? GetRewardFee { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// ״̬
        /// </summary>
        public Int32? Status { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? StatusTime { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32? Sort { get; set; }

    }
}