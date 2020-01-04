using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Shop
{
    /// <summary>
    /// �̺�
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
        /// �̺ű���
        /// </summary>
        public String ShopTitle { get; set; }

        /// <summary>
        /// �̺���ͼ
        /// </summary>
        public String ShopPic { get; set; }

        /// <summary>
        /// �̺�ժҪ
        /// </summary>
        public String ShopRemark { get; set; }

        /// <summary>
        /// �̺Ž���
        /// </summary>
        public String ShopContent { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// �̺�����
        /// </summary>
        public String TypeId { get; set; }

        /// <summary>
        /// �̺���ҵ
        /// </summary>
        public String ClassId { get; set; }

        /// <summary>
        /// ���������
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
        /// ��ϵ��
        /// </summary>
        public String Contact { get; set; }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public String ContactTel { get; set; }

        /// <summary>
        /// ��Ӫ��ַ
        /// </summary>
        public String ContactAddress { get; set; }

        /// <summary>
        /// ���뷽ʽ
        /// </summary>
        public Int32? JoinWay { get; set; }

        /// <summary>
        /// ����Ҫ��
        /// </summary>
        public String JoinDemand { get; set; }

        /// <summary>
        /// ������ã����Σ�
        /// </summary>
        public Double? JoinFeeOnce { get; set; }

        /// <summary>
        /// ������ã����£�
        /// </summary>
        public Double? JoinFeeMonth { get; set; }

        /// <summary>
        /// ������ã����꣩
        /// </summary>
        public Double? JoinFeeYear { get; set; }

        /// <summary>
        /// ������ã����ޣ�
        /// </summary>
        public Double? JoinFeeUnlimited { get; set; }

        /// <summary>
        /// �Ƿ��ƹ�
        /// </summary>
        public Int32? IsAd { get; set; }

        /// <summary>
        /// �Ƿ��ö�
        /// </summary>
        public Int32? IsTop { get; set; }

        /// <summary>
        /// �Ƿ���ˢ
        /// </summary>
        public Int32? IsRefresh { get; set; }

        /// <summary>
        /// ���޺��
        /// </summary>
        public Int32? HasReward { get; set; }

        /// <summary>
        /// �ƹ�֧��
        /// </summary>
        public Double? AdFee { get; set; }

        /// <summary>
        /// ���֧��
        /// </summary>
        public Double? RewardFee { get; set; }

        /// <summary>
        /// ��Ա����
        /// </summary>
        public Int32? MemberNum { get; set; }

        /// <summary>
        /// ��Ѷ����
        /// </summary>
        public Int32? ProductNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? LinkNum { get; set; }

        /// <summary>
        /// ˵˵����
        /// </summary>
        public Int32? ChatNum { get; set; }

        /// <summary>
        /// �ʴ�����
        /// </summary>
        public Int32? AskNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? MessageNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? AgentNum { get; set; }

        /// <summary>
        /// �п�����
        /// </summary>
        public Int32? CustomerNum { get; set; }

        /// <summary>
        /// �շ��ۼ�
        /// </summary>
        public Double? GetPayFee { get; set; }

        /// <summary>
        /// �����ۼ�
        /// </summary>
        public Double? GetRewardFee { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public Int32? ClickNum { get; set; }

        /// <summary>
        /// ��ע����
        /// </summary>
        public Int32? CollectionNum { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public Int32? GoodNum { get; set; }

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
        /// ��ע
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32? Sort { get; set; }

    }
}