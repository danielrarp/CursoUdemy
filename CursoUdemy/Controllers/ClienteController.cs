using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoUdemy.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlDecode(nombre);
            return Content(input);
        }

        [HttpGet]
        public ActionResult Buscar()
        {
            var input = "Este es un selector http get";
            return Content(input);
        }


    }
}