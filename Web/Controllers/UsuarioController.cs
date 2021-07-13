using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Usuario> model = new List<Usuario>();
            using (var context = new HavanLabsContext())
            {
                model = context.Usuarios.ToList();
            }
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            using (var context = new HavanLabsContext())
            {
                context.Usuarios.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Update(int id) 
        {
            Usuario model = new Usuario();
            using(var context = new HavanLabsContext())
            {
                model = context.Usuarios.Find(id);
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Usuario model)
        {
            using (var context = new HavanLabsContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            using (var context = new HavanLabsContext())
            {
                Usuario model = context.Usuarios.Find(id);
                context.Usuarios.Remove(model);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}