using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoUdemy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /* public ActionResult Index()
         {
             //return "Mi controlador Home";
             return RedirectToAction("TodosLosProveedores", "proveedores");
         }*/
        ////FILTERS [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MiVista()
        {
            return View();
        }
        //******FILTERS
        //[Authorize(Roles = "Admin")]
        // [OutputCache (Duration = 10)]

        [ActionName ("Hora")]
        public string horaActual()
        {
            return DateTime.Now.ToString("T");
        }

        }
}