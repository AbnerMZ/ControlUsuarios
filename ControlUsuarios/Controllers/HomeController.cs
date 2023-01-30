using ControlUsuarios.Areas.Identity.Data;
using ControlUsuarios.Models;
using Microsoft.AspNetCore.Mvc;
using Negocio.Service;
using System.Diagnostics;

namespace ControlUsuarios.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioService _productoService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IUsuarioService usuarioServ)
        {
            _logger = logger;
            _productoService = usuarioServ;
        }

        public IActionResult Index()
        {
            return View();
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