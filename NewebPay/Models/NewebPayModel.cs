using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewebPay.Models
{
    public class NewebPayModel
    {
        /// <summary>
        /// 商店代號
        /// </summary>
        [Required]
        public string MerchantID { get; set; }
        /// <summary>
        /// 交易資料AES加密
        /// </summary>
        [Required]
        public string TradeInfo { get; set; }
        /// <summary>
        /// 交易資料SHA256加密
        /// </summary>
        [Required]
        public string TradeSha { get; set; }
        /// <summary>
        /// 串接程式版本 1.6
        /// </summary>
        [Required]
        [DefaultValue("1.6")]
        public string Version { get; set; }
        /// <summary>
        /// 回傳格式
        /// </summary>
        [Required]
        public string RespondType { get; set; }
        /// <summary>
        /// 時間戳記
        /// </summary>
        [Required]
        public string TimeStamp { get; set; }
        /// <summary>
        /// 商店訂單編號
        /// </summary>
        [Required]
        public string MerchantOrderNo { get; set; }
        /// <summary>
        /// 訂單金額
        /// </summary>
        [Required]
        public int Amt { get; set; }
        /// <summary>
        /// 商品資訊
        /// </summary>
        [Required]
        public string ItemDesc { get; set; }
        /// <summary>
        /// 支付通知網址
        /// </summary>        
        public string NotifyURL { get; set; }
        /// <summary>
        /// 支付完成返回商店網址
        /// </summary>        
        public string ReturnURL { get; set; }
        /// <summary>
        /// 付款人電子信箱
        /// </summary>
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// 藍新金流會員
        /// </summary>
        [Required]
        [DefaultValue(0)]
        public int LoginType { get; set; }
        /// <summary>
        /// 信用卡一次付清啟用
        /// </summary>
        [Required]
        [DefaultValue(1)]
        public int CREDIT { get; set; }
        /// <summary>
        /// ATM 轉帳啟用
        /// </summary>
        [Required]
        [DefaultValue(1)]
        public int VACC { get; set; }
    }
}
