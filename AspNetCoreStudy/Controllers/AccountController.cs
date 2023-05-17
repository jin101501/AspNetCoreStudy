using Microsoft.AspNetCore.Mvc;
using AspNetCoreStudy.Models;
using AspNetCoreStudy.DataContext;

namespace AspNetCoreStudy.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet] 
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

        [HttpPost]
        public IActionResult Register(User model) // 동일한 메서드가 선언이 되면에러가 발생한다.
        {
            if(ModelState.IsValid) // 사용자가 필수적으로 입력해야 하는 값들이 입력이 되었는지 확인하기 위한 용도 (Model에서 선언되어 있는 Required)
            {
                // java try(SqlSession){} catch(){}

                // C#은 using문을 활용한다.
                using (var db = new AspnetNoteDbContext()) // 데이터 베이스 입출력을 할때 사용하기 위해서 선언을 해준다.
                {
                    db.Users.Add(model); // 받은 데이터를 메모리로 올리는 과정
                    db.SaveChanges();// 메모리에서 실제 SQL로 저장하는 과정
                }
                return RedirectToAction("Index", "Home"); //HomeController에 에 있는 Index로 전달을 하곘다 
            }
            return View();
        }
    }
}
