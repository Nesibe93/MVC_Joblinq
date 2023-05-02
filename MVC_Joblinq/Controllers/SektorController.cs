using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using MVC_Joblinq.Models;
using MVC_Joblinq.ViewModels;

namespace MVC_Joblinq.Controllers
{
    public class SektorController : Controller
    {
        public SektorController(DBJoblinqContext dBJoblinqContext)
        {
            DBJoblinqContext = dBJoblinqContext;
        }
        public DBJoblinqContext DBJoblinqContext { get; }

        public IActionResult Index()
        {
            var data = DBJoblinqContext.Sectors.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Sektor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Sektor(SektorVM sektor)
        {
           
            var data = new Sector()
            {
                SectorName = sektor.SectorName,
                
            };
           
            DBJoblinqContext.Sectors.Add(data);
            DBJoblinqContext.SaveChanges();

            return RedirectToAction("index", "Home");

           
        }

    }
}
