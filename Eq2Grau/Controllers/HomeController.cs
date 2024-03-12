using Eq2Grau.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eq2Grau.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        /// <summary>
        /// M�todo para Calcular as raizes e uma equa��o do 2� grau
        /// </summary>
        /// <param name="A">parametro do x^2</param>
        /// <param name="B">parametro do x</param>
        /// <param name="C">parametro independente</param>
        /// <returns></returns>
     
        public IActionResult Index(String A, String B, String C)
        {
            /* Algoritmo
             * 1- parametros A, B, C
             * 2- Validar se pode fazer opera��es com eles
             *  2.1- t�m de ser n�meros
             *  2.2- A != 0
             * 3- se posso calcular,
             *  3.1- determinar as ra�zes
             *      3.1.1- 
             * 
             * 
             */
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
