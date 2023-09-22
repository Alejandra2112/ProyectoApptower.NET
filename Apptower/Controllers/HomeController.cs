using Apptower.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Apptower.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApptowerProvicionalContext _context;
        public HomeController(ApptowerProvicionalContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }
        [Authorize]
        public IActionResult Index()
        {
            var listaresidentes = _context.Residentes.ToList();
            // Hacer algo con el objeto "residente"
            return View(listaresidentes);
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