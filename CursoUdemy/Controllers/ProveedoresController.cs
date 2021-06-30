using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoUdemy.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public string TodosLosProveedores()
        {
            return @"<ul>
                         <li>proveedor 1</li>
                         <li>proveedor 2</li>
                         <li>proveedor 3</li>
                     </ul>";
        }
    }
}