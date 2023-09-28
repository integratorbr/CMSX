using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcAlivre.Models;

namespace mvcAlivre.Controllers
{
    public class CampusController : Controller
    {
        private cainaprova_1Entities db = new cainaprova_1Entities();

        // GET: Campus
        public async Task<ActionResult> Index()
        {
            var campus = db.Campus.Include(c => c.Instituicao);
            return View(await campus.ToListAsync());
        }


        // GET: Show
        public ActionResult Show(short? inst, short? id)
        {
            var campus = db.Campus.Find(inst,id);
            //ViewBag.SelectedDepartment = new SelectList(campus, "NumCampus", "NomeCampus", idCampus);
            int NumCampus = id.GetValueOrDefault();

            /*IQueryable<Curso> cursos = db.Curso
                .Where(c => !idCampus.HasValue || c.NumCampus == NumCampus)
                .OrderBy(d => d.NumCurso)
                .Include(d => d.Campus);
            var sql = cursos.ToString();*/
            return View(campus);
        }

        // GET: Campus/Details/5
        public async Task<ActionResult> Details(short? inst,short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campus campus = await db.Campus.FindAsync(inst,id);
            if (campus == null)
            {
                return HttpNotFound();
            }
            return View(campus);
        }

        // GET: Campus/Create
        public ActionResult Create()
        {
            ViewBag.NumInstituicao = new SelectList(db.Instituicao, "NumInstituicao", "NomeInstituicao");
            return View();
        }

        // POST: Campus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "NumInstituicao,NumCampus,NomeCampus")] Campus campus)
        {
            if (ModelState.IsValid)
            {
                db.Campus.Add(campus);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.NumInstituicao = new SelectList(db.Instituicao, "NumInstituicao", "NomeInstituicao", campus.NumInstituicao);
            return View(campus);
        }

        // GET: Campus/Edit/5
        public async Task<ActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campus campus = await db.Campus.FindAsync(id);
            if (campus == null)
            {
                return HttpNotFound();
            }
            ViewBag.NumInstituicao = new SelectList(db.Instituicao, "NumInstituicao", "NomeInstituicao", campus.NumInstituicao);
            return View(campus);
        }

        // POST: Campus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "NumInstituicao,NumCampus,NomeCampus")] Campus campus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campus).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.NumInstituicao = new SelectList(db.Instituicao, "NumInstituicao", "NomeInstituicao", campus.NumInstituicao);
            return View(campus);
        }

        // GET: Campus/Delete/5
        public async Task<ActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campus campus = await db.Campus.FindAsync(id);
            if (campus == null)
            {
                return HttpNotFound();
            }
            return View(campus);
        }

        // POST: Campus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(short id)
        {
            Campus campus = await db.Campus.FindAsync(id);
            db.Campus.Remove(campus);
            await db.SaveChangesAsync();
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
