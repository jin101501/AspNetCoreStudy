using AspNetCoreStudy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
namespace AspNetCoreStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var firstUser = new User();
            //firstUser.UserNo = 1;
            //firstUser.UserName = "홍길동";

            var firstUser = new User
            {
                UserNo = 1,
                UserName="홍길동"
            };
            // # 1번째 방식 View(model)
            // return View(firstUser);

            //# 2번째 방식 View Bag
            //ViewBag.User = firstUser;
            return View(firstUser);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}