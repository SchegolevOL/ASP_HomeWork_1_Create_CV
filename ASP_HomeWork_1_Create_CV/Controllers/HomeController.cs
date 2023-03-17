using ASP_HomeWork_1_Create_CV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_HomeWork_1_Create_CV.Controllers
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
            ViewBag.Questionnaire = new Questionnaire()
            {
                FirstName = "Oleg",
                LastName = "Schegolev",
                Patronymic = "Leonidovich",
                Phone = "+79094125553",
                Foto = "/img/foto.jpg"
			};
            
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}