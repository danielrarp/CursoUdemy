using CursoUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoUdemy.Controllers
{
    public class ClientesController : Controller
    {

        public static List<Clientes> empList = new List<Clientes>
        {
            new Clientes
            {
                id = 1,
                nombre =  "DanielStatic",
                fechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                edad = 28
            },
            new Clientes
            {
                id = 2,
                nombre =  "XStatic",
                fechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                edad = 389
            },

        };


        private EmpDBContext db = new EmpDBContext();

        [OutputCache (CacheProfile = "Cache5Minutos")]
        // GET: Clientes
        public ActionResult Index()
        {
    
                var Clientes = from e in db.Clientes//empList
                           orderby e.id
                           select e;
            return View(Clientes);
        }

        // GET: Clientes/Details/5
        [OutputCache (Duration = int.MaxValue, VaryByParam = "id")]
        public ActionResult Details(int id)
        {
            var Clientes = db.Clientes.SingleOrDefault(e => e.id == id);
            return View(Clientes);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes emp)
        {
            try
            {

                //forma larga 
                /* Clientes emp = new Models.Clientes();
                 emp.nombre = collection["nombre"];
                 DateTime jDate;
                 DateTime.TryParse(collection["DOB"], out jDate);
                 emp.fechaAlta = jDate;
                 string edad = collection["edad"];
                 emp.edad = Int32.Parse(edad);
                 empList.Add(emp);*/

                //forma corta 
                //empList.Add(emp);
                db.Clientes.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
           // List<Clientes> empList = TodosLosClientes();
            var Clientes = db.Clientes.Single(m => m.id == id);
            return View(Clientes);

            
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var Clientes = db.Clientes.Single(m => m.id == id);
                if (TryUpdateModel(Clientes))
                    db.SaveChanges();
                    return RedirectToAction("Index");


                return View(Clientes);
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Clientes> TodosLosClientes()
        {
            return new List<Clientes>
            {
                new Clientes
                {
                    id = 1,
                    nombre = "Daniel",
                    fechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad = 28
                },
                new Clientes
                {
                    id = 2,
                    nombre = "x",
                    fechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad = 100
                },
            };
        }
    }
}
