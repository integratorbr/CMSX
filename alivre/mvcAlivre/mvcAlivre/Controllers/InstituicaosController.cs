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
    public class InstituicaosController : Controller
    {
        private cainaprova_1Entities db = new cainaprova_1Entities();

        // GET: Instituicaos
        public async Task<ActionResult> Index()
        {
            var inst = db.Instituicao.Include(i => i.Campus);
            return View(await inst.Take(10).ToListAsync());
        }

        // GET: Instituicaos/Details/5
        public async Task<ActionResult> Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instituicao instituicao = await db.Instituicao.FindAsync(id);
            if (instituicao == null)
            {
                return HttpNotFound();
            }

            return View(instituicao);
        }

        // GET: Instituicaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instituicaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "NumInstituicao,NomeInstituicao,UfInstituicao,CidInstituicao")] Instituicao instituicao)
        {
            if (ModelState.IsValid)
            {
                db.Instituicao.Add(instituicao);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(instituicao);
        }

        // GET: Instituicaos/Edit/5
        public async Task<ActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instituicao instituicao = await db.Instituicao.FindAsync(id);
            if (instituicao == null)
            {
                return HttpNotFound();
            }
            return View(instituicao);
        }

        // POST: Instituicaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "NumInstituicao,NomeInstituicao,UfInstituicao,CidInstituicao")] Instituicao instituicao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instituicao).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(instituicao);
        }

        // GET: Instituicaos/Delete/5
        public async Task<ActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instituicao instituicao = await db.Instituicao.FindAsync(id);
            if (instituicao == null)
            {
                return HttpNotFound();
            }
            return View(instituicao);
        }

        // POST: Instituicaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(short id)
        {
            Instituicao instituicao = await db.Instituicao.FindAsync(id);
            db.Instituicao.Remove(instituicao);
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
