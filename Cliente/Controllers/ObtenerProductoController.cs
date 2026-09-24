using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cliente.ServicioWFCReference1;

namespace Cliente.Controllers
{
    public class ObtenerProductoController : Controller
    {
        // GET: ObtenerProductoDefault
        public ActionResult Index()
        {
            Service1Client service1Client = new Service1Client();

            //Obtenemos el producto por el ID, en este caso el producto con ID=4
            return Json(service1Client.ObtenerProducto(4), JsonRequestBehavior.AllowGet);
        }

        // GET: ObtenerProductoDefault/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ObtenerProductoDefault/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ObtenerProductoDefault/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ObtenerProductoDefault/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ObtenerProductoDefault/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ObtenerProductoDefault/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ObtenerProductoDefault/Delete/5
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
    }
}
