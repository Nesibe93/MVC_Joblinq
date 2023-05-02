using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MVC_Joblinq.Models;
using MVC_Joblinq.ViewModels;

namespace MVC_Joblinq.Controllers
{
    public class LoginController : Controller
    {
        public LoginController(DBJoblinqContext dBJoblinqContext)
        {
            DBJoblinqContext = dBJoblinqContext;
        }
        public DBJoblinqContext DBJoblinqContext { get; }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM login) 
        {
            var user = DBJoblinqContext.Users.Where(u => u.UserEmail == login.UserEmail);
            // DB tarafındaki tabloda ekrandan girilen email adresi ile ilgili bir kayıt vardır

            if (user.Any()) // email bilgisi uyan herhangi bir kayıt bulduysan
            {
                
                if (user.Where(u => u.UserPassword == login.UserPassword).Any()) // password bilgisi uyan herhangi bir kayıt var mı
                {
                    return RedirectToAction("Index", "Home");
                    //return Json(new { Success = true, message = "Giriş Başarılı" });
                }
                else 
                {
                    return RedirectToAction("Error", "Home");
                    
                }
            }




            return View();
        }


    }
}
