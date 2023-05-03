using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVC_Joblinq.Models;
using MVC_Joblinq.ViewModels;

namespace MVC_Joblinq.Controllers
{
    public class RegisterController : Controller
    {
        // Constructor
        public RegisterController(DBJoblinqContext dBJoblinqContext)
        {
            DBJoblinqContext = dBJoblinqContext;
        }
        public DBJoblinqContext DBJoblinqContext { get;}

        [HttpGet] // Sayfayı getir
        public IActionResult Register()
        {

           ViewBag.usertype = new SelectList(new List<UserType>()
            {
                new(){Data="K",Value="Kullanıcı"},
                 new(){Data="S",Value= "Şirket"},
                }, "Data", "Value");

            return View();
        }

        //public IActionResult Register(User user)
        //{
        //    // View tarafında girilen bilgilerin Veritabanı tarafına atanması
        //    var data = new User()
        //    {
        //        UserEmail = user.UserEmail,
        //        UserPassword = user.UserPassword,
        //        UserType = user.UserType
        //    };
        //    // Verilerin database e yazılması
        //    // Burada benim DBContext i kullanarak yazma işlemi gerçekleşecek.Bu yüzden en başlangıca bu tanımı yapmak gerekiyor(Constructor ile)

        //    DBJoblinqContext.Users.Add(data);
        //    DBJoblinqContext.SaveChanges();

        //    return RedirectToAction("index","Home");

        //}
        [HttpPost]
        public IActionResult Register(RegisterVM register)
        {
            
        
            return View();
        }
        }
    }

