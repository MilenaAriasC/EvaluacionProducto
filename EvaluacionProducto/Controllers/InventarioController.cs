using EvaluacionProducto.BussinesLayer;
using EvaluacionProducto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvaluacionProducto.Controllers
{
    public class InventarioController : Controller

    {
        private InventarioBL inventariobl = new InventarioBL();
        private ProductoBL productobl = new ProductoBL();

        Inventario inv= new Inventario();
        // GET: Inventario
        public ActionResult Index()
        {
            return View(inventariobl.listar());
        }

        // GET: Inventario/Details/5
        public ActionResult Details(int IdInventario)
        {
            return View();
        }

        // GET: Inventario/Create
        public ActionResult Create()
        {
            ViewBag.IdProducto = new SelectList(productobl.listar(), "IdProducto", "nombre");
            return View();
            
        }

        // POST: Inventario/Create
        [HttpPost]
        public ActionResult Create(Inventario inventario)
        {
            try
            {
                // TODO: Add insert logic here
                inventariobl.guardar(inventario);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inventario/Edit/5
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

        // GET: Inventario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inventario/Delete/5
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
