using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.id = 001;
            producto1.Descripcion = "Pizza Peperoni";

            var producto2 = new ProductoModel();
            producto2.id = 002;
            producto2.Descripcion = "Pizza Jamon y Quezo";

            var producto3 = new ProductoModel();
            producto3.id = 003;
            producto3.Descripcion = "Pizza Mixta (Peperoni/Jamon y Queso)";

            var producto4 = new ProductoModel();
            producto4.id = 004;
            producto4.Descripcion = "Pizza Con Piña";

            var Lista = new List<ProductoModel>();
            Lista.Add(producto1);
            Lista.Add(producto2);
            Lista.Add(producto3);
            Lista.Add(producto4);

            return View(Lista);
        }
    }
}