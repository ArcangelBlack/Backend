using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DeliverBackend.Models;

namespace DeliverBackend.Controllers
{
    public class TransportersController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Transporters
        public async Task<ActionResult> Index()
        {
            return View(await db.Transporters.ToListAsync());
        }

        // GET: Transporters/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporter transporter = await db.Transporters.FindAsync(id);
            if (transporter == null)
            {
                return HttpNotFound();
            }
            return View(transporter);
        }

        // GET: Transporters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transporters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Surnames,Photo,BirthdayDate,Email,Password,Points,CreatedAt,UpdatedAt,Deleted,Version")] Transporter transporter)
        {
            if (ModelState.IsValid)
            {
                db.Transporters.Add(transporter);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(transporter);
        }

        // GET: Transporters/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporter transporter = await db.Transporters.FindAsync(id);
            if (transporter == null)
            {
                return HttpNotFound();
            }
            return View(transporter);
        }

        // POST: Transporters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Surnames,Photo,BirthdayDate,Email,Password,Points,CreatedAt,UpdatedAt,Deleted,Version")] Transporter transporter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transporter).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(transporter);
        }

        // GET: Transporters/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporter transporter = await db.Transporters.FindAsync(id);
            if (transporter == null)
            {
                return HttpNotFound();
            }
            return View(transporter);
        }

        // POST: Transporters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Transporter transporter = await db.Transporters.FindAsync(id);
            db.Transporters.Remove(transporter);
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
