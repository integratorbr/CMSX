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
    public class DisciplinasController : Controller
    {
        private cainaprova_1Entities db = new cainaprova_1Entities();

        // GET: Disciplinas
        public async Task<ActionResult> Index()
        {
            var disciplina = db.Disciplina.Include(d => d.Turma);
            return View(await disciplina.ToListAsync());
        }

        // GET: Disciplinas/Details/5
        public async Task<ActionResult> Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = await db.Disciplina.FindAsync(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // GET: Disciplinas/Create
        public ActionResult Create()
        {
            ViewBag.NumInstituicao = new SelectList(db.Turma, "NumInstituicao", "NomeTurma");
            return View();
        }

        // POST: Disciplinas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "NumInstituicao,NumCampus,NumCurso,NumTurma,NumDisciplina,NomeDisciplina,NumProfessor,Status")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                db.Disciplina.Add(disciplina);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.NumInstituicao = new SelectList(db.Turma, "NumInstituicao", "NomeTurma", disciplina.NumInstituicao);
            return View(disciplina);
        }

        // GET: Disciplinas/Edit/5
        public async Task<ActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = await db.Disciplina.FindAsync(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            ViewBag.NumInstituicao = new SelectList(db.Turma, "NumInstituicao", "NomeTurma", disciplina.NumInstituicao);
            return View(disciplina);
        }

        // POST: Disciplinas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "NumInstituicao,NumCampus,NumCurso,NumTurma,NumDisciplina,NomeDisciplina,NumProfessor,Status")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disciplina).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.NumInstituicao = new SelectList(db.Turma, "NumInstituicao", "NomeTurma", disciplina.NumInstituicao);
            return View(disciplina);
        }

        // GET: Disciplinas/Delete/5
        public async Task<ActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = await db.Disciplina.FindAsync(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // POST: Disciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(short id)
        {
            Disciplina disciplina = await db.Disciplina.FindAsync(id);
            db.Disciplina.Remove(disciplina);
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
