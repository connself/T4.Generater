
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cloud.Models
{	
    [Table("member_coupons")]
	public partial class member_coupons
    {
		
        /// <summary>
        /// 
        /// </summary>        
        [Key]        
        public string C_Id { get; set; }
        
        /// <summary>
        /// 商户编号
        /// </summary>        
        public string C_UserId { get; set; }
        
        /// <summary>
        /// 门店编号
        /// </summary>        
        public string C_ShopNo { get; set; }
        
        /// <summary>
        /// 会员编号
        /// </summary>        
        public string C_MebNo { get; set; }
        
        /// <summary>
        /// 状态 1可使用 2已使用 3不可用
        /// </summary>        
        public int N_Status { get; set; }
        
        /// <summary>
        /// 领取时间
        /// </summary>        
        public DateTime D_CreateTime { get; set; }
        
        /// <summary>
        /// 可使用开始时间
        /// </summary>        
        public DateTime D_StartTime { get; set; }
        
        /// <summary>
        /// 可使用结束时间
        /// </summary>        
        public DateTime? D_EndTime { get; set; }
        
        /// <summary>
        /// 使用时间
        /// </summary>        
        public DateTime? D_UsedTime { get; set; }
        
        /// <summary>
        /// 使用日期类型 1每天 2每月 3每周 
        /// </summary>        
        public int N_UsableDateType { get; set; }
        
        /// <summary>
        /// 具体使用日期/周 如：每月1,2,3/每周1,2,3
        /// </summary>        
        public string C_UsableDate { get; set; }
        
        /// <summary>
        /// 具体的使用时间 如：10:00-11:00,15:00-17:00
        /// </summary>        
        public string C_UsableTime { get; set; }
        
        /// <summary>
        /// 优惠券码
        /// </summary>        
        public string C_CouponCode { get; set; }
        
        /// <summary>
        /// 优惠券类型 1现金券 2折扣券 3随机券
        /// </summary>        
        public int N_CouponType { get; set; }
        
        /// <summary>
        /// 优惠券面额 类型为1/3时为金额(8.00元) 2为折扣(9.5折)
        /// </summary>        
        public decimal N_CouponAmount { get; set; }
        
        /// <summary>
        /// 满多少元可使用 0无限制
        /// </summary>        
        public decimal N_MinUseAmount { get; set; }
        
        /// <summary>
        /// 优惠券名称
        /// </summary>        
        public string C_CouponName { get; set; }
        
        /// <summary>
        /// 优惠券组
        /// </summary>        
        public string C_CouponGroup { get; set; }
        
        /// <summary>
        /// 是否连续使用 0不连续 -1没使用时后面全部作废 >1没使用时作废n张
        /// </summary>        
        public int N_NextContinued { get; set; }
        
        /// <summary>
        /// 备注说明
        /// </summary>        
        public string C_Remark { get; set; }
        
        /// <summary>
        /// 来源类型 1自己领取 2店铺发送
        /// </summary>        
        public int N_SourceType { get; set; }
        
        /// <summary>
        /// 关联的活动编号
        /// </summary>        
        public string C_MkId { get; set; }
        
        /// <summary>
        /// 关联的活动类型
        /// </summary>        
        public int N_MkType { get; set; }
        
        /// <summary>
        /// 关联的活动名称
        /// </summary>        
        public string C_MkName { get; set; }
        
        /// <summary>
        /// 针对商品 0全场通用 1指定商品可用 2指定分类可用 3指定商品不可用 2指定分类不可用 
        /// </summary>        
        public int N_GoodsScope { get; set; }
        
        /// <summary>
        /// 对应商品/分类
        /// </summary>        
        public string C_GoodsIds { get; set; }
           
    }
}

