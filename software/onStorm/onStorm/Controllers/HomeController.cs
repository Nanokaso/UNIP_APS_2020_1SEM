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
        //https://portal.vidadesilicio.com.br/lm35-medindo-temperatura-com-arduino/
        public IActionResult Index ()
        {
            var banco = new Banco();
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

        [HttpGet]
        public JsonResult GetLocais ()
        {
            try
            {
                var banco = new Banco();
                var dispositivos = banco.GetDispositivos();

                var imgbr = "img/dot green.png";
                var img = "img/dot grey.png";
                return Json(new
                {
                    status = 0,
                    lista = dispositivos.Select(x => new
                    {
                        x.nome, lat =
                        x.local.Split('_')[0],
                        lon = x.local.Split('_')[1],
                        img = (x.nome.Contains(" BRA") ? imgbr : img)
                    }),
                    message = ""
                });

            }
            catch( Exception ex )
            {
                return Json(new
                {
                    status = 500,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        public JsonResult AtualizarLocais ()
        {
            try
            {
                dataBasic.incluirDispositivos();
                return Json(new
                {
                    status = 0,                    
                    message = ""
                });

            }
            catch( Exception ex )
            {
                return Json(new
                {
                    status = 500,
                    message = ex.Message
                });
            }
        }

    }
}
