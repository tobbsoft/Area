using AreaUygulama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AreaUygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Anasayfa")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Hakkinda")]
        public IActionResult About()
        {
            return View();
        }
        [Route("Iletisim")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            // LINQ - Language Integrated Query

            Admin? x = AdminInit.Init().FirstOrDefault(x=>x.Username == admin.Username && x.Password == admin.Password);

            if(x != null)
            {
                return RedirectToAction("Index", "Admin", new {area = "Admin"});
            }
            else
            {
                ViewBag.LoginError = "Hatalı kullanıcı adı ya da şifre";
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}