using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
           var proyecto = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModels() { proyectos = proyecto };

            return View(modelo);
        }

        private List<ProyectoDT> ObtenerProyectos()
        {


            return new List<ProyectoDT>() {
                new ProyectoDT() {

                    Titulo = "Amazon",
                    Descripcion = "Pagina de comercio en ASP.NET Core",
                    link = "https://www.amazon.com",
                    ImagenURL = "/Imagenes/amazon.png"
                },

                 new ProyectoDT() {

                    Titulo = "NewYorkTimes",
                    Descripcion = "Pagina de Noticias",
                    link = "https://www.nytimes.com",
                    ImagenURL = "/Imagenes/nyt.png"
                },
                  new ProyectoDT() {

                    Titulo = "Colgate",
                    Descripcion = "Pagina de ",
                    link = "https://www.colgate.com",
                    ImagenURL = "/Imagenes/Colgate.png"
                },
                   new ProyectoDT() {

                    Titulo = "Steam",
                    Descripcion = "Pagina de venta de VideoJuegos",
                    link = "https://www.Steam.com",
                    ImagenURL = "/Imagenes/steam.png"
                },
            };
                       
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