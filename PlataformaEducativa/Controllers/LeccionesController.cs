using PlataformaEducativa.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace PlataformaEducativa.Controllers
{
    public class LeccionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        public ActionResult Index()
        {
            var lecciones = db.Lecciones.Include(l => l.Curso); 
            return View(lecciones.ToList());
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leccion leccion = db.Lecciones.Include(l => l.Curso).FirstOrDefault(l => l.Id == id);
            if (leccion == null)
            {
                return HttpNotFound();
            }
            return View(leccion);
        }

        
        public ActionResult Create()
        {
            ViewBag.CursoId = new SelectList(db.Cursos, "Id", "Titulo");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,Contenido,Orden,VideoUrl,IdCurso")] Leccion leccion)
        {
            if (ModelState.IsValid)
            {
                db.Lecciones.Add(leccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CursoId = new SelectList(db.Cursos, "Id", "Titulo", leccion.IdCurso);
            return View(leccion);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leccion leccion = db.Lecciones.Find(id);
            if (leccion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoId = new SelectList(db.Cursos, "Id", "Titulo", leccion.IdCurso);
            return View(leccion);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,Contenido,Orden,VideoUrl,IdCurso")] Leccion leccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CursoId = new SelectList(db.Cursos, "Id", "Titulo", leccion.IdCurso);
            return View(leccion);
        }

        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leccion leccion = db.Lecciones.Include(l => l.Curso).FirstOrDefault(l => l.Id == id);
            if (leccion == null)
            {
                return HttpNotFound();
            }
            return View(leccion);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Leccion leccion = db.Lecciones.Find(id);
            db.Lecciones.Remove(leccion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}