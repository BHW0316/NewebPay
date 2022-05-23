using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewebPay.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        private readonly string hashKey;
        private readonly string hashIV;
        private readonly string tradeURL;
        private readonly string creditURL;
        private readonly string host;

        public PaymentController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            hashKey = _configuration["NewebPay:HashKey"];
            hashIV = _configuration["NewebPay:HashIV"];
            tradeURL = _configuration["NewebPay:TradeURL"];
            creditURL = _configuration["NewebPay:CreditURL"];
            host = "https://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
