using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AspNetCoreStudy.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();  // 로그인 화면 구성
        }
        /// <summary>
        /// 회원가입
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public IActionResult Register()
        {
            return View();  // 회원가입 화면 호출
        }
    }
}
