using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using onStorm.Models;
using Microsoft.AspNetCore.Http;

namespace onStorm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index ()
        {
            var banco = new Banco();
            banco.incluirDispositivo(new dispositivoModel() { idDisp = banco.getGuid(), local = banco.getGuid(), nome = banco.getGuid() });
            var dispositivos = banco.GetDispositivos();
            banco.incluirRegistro(dispositivos.FirstOrDefault().idDisp, 50, 60);
            var registros = banco.GetRegistros();
            return View();
        }

        public IActionResult Privacy ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error ()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
