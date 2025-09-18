using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StocksApp.Services;


namespace StocksApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinnhubService _finnhubService;

        public HomeController(FinnhubService finnhubService)
        {
            _finnhubService = finnhubService;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {

            Dictionary<string, object>? responseDictionary = await _finnhubService.GetStockPriceQuote("MSFT");

            return View();
        }
    }
}