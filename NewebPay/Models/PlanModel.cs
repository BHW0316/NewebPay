using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewebPay.Models
{
    public class PlanModel
    {
        /// <summary>
        /// 使用者Id
        /// </summary>

        [Required(ErrorMessage = "必填欄位")]
        public long UserId { get; set; }
        /// <summary>
        /// 訂閱計畫名稱
        /// </summary>

        [Required(ErrorMessage = "必填欄位")]
        public string PlanName { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        [Required(ErrorMessage = "必填欄位")]
        public int Amt { get; set; }
    }
}
