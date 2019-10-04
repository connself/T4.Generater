
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cloud.Models
{	
    [Table("member")]
	public partial class member
    {
		
        /// <summary>
        /// 
        /// </summary>        
        [Key]        
        public string C_MebId { get; set; }
        
        /// <summary>
        /// 商户编号
        /// </summary>        
        public string C_UserId { get; set; }
        
        /// <summary>
        /// 外键，店铺编号  平台会员为平台店铺的店铺编号
        /// </summary>        
        public string C_ShopNo { get; set; }
        
        /// <summary>
        /// 会员等级
        /// </summary>        
        public string C_GradeId { get; set; }
        
        /// <summary>
        /// 编号，可创建索引
        /// </summary>        
        public string C_MebNo { get; set; }
        
        /// <summary>
        /// 昵称
        /// </summary>        
        public string C_NickName { get; set; }
        
        /// <summary>
        /// 会员名称
        /// </summary>        
        public string C_MebName { get; set; }
        
        /// <summary>
        /// 女士/先生/保密 1 2 3
        /// </summary>        
        public int C_MebSex { get; set; }
        
        /// <summary>
        /// 会员积分
        /// </summary>        
        public int N_Integral { get; set; }
        
        /// <summary>
        /// 会员电话
        /// </summary>        
        public string C_MebPhone { get; set; }
        
        /// <summary>
        /// 生日1 公历；2农历
        /// </summary>        
        public int C_BrdWay { get; set; }
        
        /// <summary>
        /// 会员生日日期
        /// </summary>        
        public string D_BirthDay { get; set; }
        
        /// <summary>
        /// 照片
        /// </summary>        
        public string C_MebPic { get; set; }
        
        /// <summary>
        /// 推荐人手机号
        /// </summary>        
        public string C_MebRecNo { get; set; }
        
        /// <summary>
        /// 账户余额
        /// </summary>        
        public decimal N_MebAmount { get; set; }
        
        /// <summary>
        /// 过期时间
        /// </summary>        
        public DateTime? D_DutTime { get; set; }
        
        /// <summary>
        /// 小程序的openid
        /// </summary>        
        public string C_XcxOpenid { get; set; }
        
        /// <summary>
        /// 微信openid
        /// </summary>        
        public string C_Openid { get; set; }
        
        /// <summary>
        /// 真实姓名
        /// </summary>        
        public string C_RealName { get; set; }
        
        /// <summary>
        /// 状态 1 有效 2删除
        /// </summary>        
        public int N_State { get; set; }
        
        /// <summary>
        /// 地址
        /// </summary>        
        public string C_Address { get; set; }
        
        /// <summary>
        /// 消费金额
        /// </summary>        
        public decimal N_ConAmount { get; set; }
        
        /// <summary>
        /// 开通年
        /// </summary>        
        public int? N_Year { get; set; }
        
        /// <summary>
        /// 开通月
        /// </summary>        
        public int? N_Month { get; set; }
        
        /// <summary>
        /// 卡号
        /// </summary>        
        public string C_CardNo { get; set; }
        
        /// <summary>
        /// 登陆密码
        /// </summary>        
        public string C_MebPwd { get; set; }
        
        /// <summary>
        /// 卡状态 0 初始化，1 正常，2 挂失 3 过期 4  已换卡 5  锁定
        /// </summary>        
        public int N_CardState { get; set; }
        
        /// <summary>
        /// 省份
        /// </summary>        
        public string C_Province { get; set; }
        
        /// <summary>
        /// 城市
        /// </summary>        
        public string C_City { get; set; }
        
        /// <summary>
        /// 区域
        /// </summary>        
        public string C_Area { get; set; }
        
        /// <summary>
        /// 是否实名认证 0 未认证 1 已认证
        /// </summary>        
        public int N_IsCertification { get; set; }
        
        /// <summary>
        /// 推广二维码图片地址
        /// </summary>        
        public string C_PromoteImg { get; set; }
        
        /// <summary>
        /// 消费密码
        /// </summary>        
        public string C_PayPwd { get; set; }
        
        /// <summary>
        /// 最近一次充值时间
        /// </summary>        
        public DateTime? D_LastRechargeTime { get; set; }
        
        /// <summary>
        /// 最近一次消费时间
        /// </summary>        
        public DateTime? D_LastConsumptionTime { get; set; }
        
        /// <summary>
        /// 排序
        /// </summary>        
        public long N_Sort { get; set; }
        
        /// <summary>
        /// 支付宝userid
        /// </summary>        
        public string C_PayUserId { get; set; }
        
        /// <summary>
        /// 初始来源 1系统 2微信 3支付宝 4手机注册 5扫脸   6  一兆韦会员
        /// </summary>        
        public int N_SourceInit { get; set; }
        
        /// <summary>
        /// 消费次数
        /// </summary>        
        public int N_SaleCount { get; set; }
        
        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。
        /// </summary>        
        public string C_UnionID { get; set; }
        
        /// <summary>
        /// 添加员工
        /// </summary>        
        public string C_OpId { get; set; }
        
        /// <summary>
        /// 添加时间
        /// </summary>        
        public DateTime D_OpDate { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string C_QQ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string C_Email { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string C_MemberTag { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string C_WxAccount { get; set; }
        
        /// <summary>
        /// 
        /// </summary>        
        public string C_IDCard { get; set; }
        
        /// <summary>
        /// 迁移的数据id
        /// </summary>        
        public int? N_LyId { get; set; }
        
        /// <summary>
        /// 冻结金额
        /// </summary>        
        public decimal D_FreezingAmount { get; set; }
           
    }
}

