using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace lab14.Controllers
{
    public class CategoriesController : Controller
    {
        #region Contexto
        private northwndEntities _contexto;
        public northwndEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new northwndEntities();
                return _contexto;
            }
        }
        #endregion
        // GET: Categories
        public ActionResult Index()
        {
            return View(Contexto.Categories.ToList());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            var productosPorCategoria = from p in Contexto.Products
                                        orderby p.ProductName ascending
                                        where p.CategoryID == id
                                        select p;
            return View(productosPorCategoria.ToList());
        }

        // GET: /Categories/Create
        //mostrar formulario
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Categories/Create
        // registrar nueva categoria en la database
        [HttpPost]
        public ActionResult Create(Categories nuevaCategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Categories.Add(nuevaCategoria);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevaCategoria);
            }
            catch
            {
                return View();
            }
        }

        // GET: /Categories/Edit/5
        //muestra formulario para edicion
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Categories CategoriaEditar = Contexto.Categories.Find(id);
            if (CategoriaEditar == null)
                return HttpNotFound();
            return View(CategoriaEditar);
        }

        // POST: /Categories/Edit/5
        //registrar cambios de la categoria en la BD
        [HttpPost]
        public ActionResult Edit(Categories CategoriaEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(CategoriaEditar).State = EntityState.Modified;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEditar);
            }
            catch
            {
                return View();
            }
        }
        // GET: /categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Categories CategoriaEliminar = Contexto.Categories.Find(id);
            if (CategoriaEliminar == null)
                return HttpNotFound();
            return View(CategoriaEliminar);
        }

        // POST: /Categories/Delete/5        
        [HttpPost]
        public ActionResult Delete(int? id, Categories Categoria1)
        {
            try
            {
                Categories CategoriaEliminar = new Categories();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    CategoriaEliminar = Contexto.Categories.Find(id);
                    if (CategoriaEliminar == null)
                        return HttpNotFound();
                    Contexto.Categories.Remove(CategoriaEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}