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
    public class TextoesController : Controller
    {
        private cainaprova_1Entities db = new cainaprova_1Entities();

        // GET: Textoes
        public async Task<ActionResult> Index()
        {
            return View(await db.Texto.Take(100).ToListAsync());
        }

        // GET: Textoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Texto texto = await db.Texto.FindAsync(id);
            if (texto == null)
            {
                return HttpNotFound();
            }
            return View(texto);
        }

        // GET: Textoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Textoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "NumInstituicao,NumCampus,NumCurso,NumTurma,NumDisciplina,NumTexto,CodTexto,NomeTexto,DtInclusao,QtdeDownload,UrlTexto,TamTexto,FormTexto,SenhaTexto,SitTexto")] Texto texto)
        {
            if (ModelState.IsValid)
            {
                db.Texto.Add(texto);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(texto);
        }

        // GET: Textoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Texto texto = await db.Texto.FindAsync(id);
            if (texto == null)
            {
                return HttpNotFound();
            }
            return View(texto);
        }

        // POST: Textoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "NumInstituicao,NumCampus,NumCurso,NumTurma,NumDisciplina,NumTexto,CodTexto,NomeTexto,DtInclusao,QtdeDownload,UrlTexto,TamTexto,FormTexto,SenhaTexto,SitTexto")] Texto texto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(texto).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(texto);
        }

        // GET: Textoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Texto texto = await db.Texto.FindAsync(id);
            if (texto == null)
            {
                return HttpNotFound();
            }
            return View(texto);
        }

        // POST: Textoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Texto texto = await db.Texto.FindAsync(id);
            db.Texto.Remove(texto);
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
