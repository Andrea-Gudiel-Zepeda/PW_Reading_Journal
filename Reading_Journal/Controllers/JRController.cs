using Microsoft.AspNetCore.Mvc;
using Reading_Journal.Models;
using System.Diagnostics;

namespace Reading_Journal.Controllers
{
    public class JRController : Controller
    {
        private readonly ILogger<JRController> _logger;

        public JRController(ILogger<JRController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Pagina_Principal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pagina_Principal(string id)
        {
            return View();
        }

        public IActionResult SingIn()
        {
            return View();
        }

        public IActionResult SingUp()
        {
            return View();
        }

        public IActionResult Recoverpw()
        {
            return View();
        }

        public IActionResult User_Profile()
        {
            return View();
        }

        public IActionResult error404()
        {
            return View();
        }

        public IActionResult AcercaDe()
        {
            return View();
        }

        public IActionResult Read_List()
        {
            return View();
        }

        public IActionResult Buy_List()
        {
            return View();
        }

        public IActionResult ToDo_List()
        {
            return View();
        }

        public IActionResult CreateBook()
        {
            return View();
        }

        public IActionResult UpdateBook()
        {
            return View();
        }

        public IActionResult ZonaReseñas()
        {
            return View();
        }

        public IActionResult CreateReseña()
        {
            return View();
        }

        public IActionResult UpdateReseña()
        {
            return View();
        }

        public IActionResult Terms_Service()
        {
            return View();
        }

        public IActionResult Privacy_Policy()
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