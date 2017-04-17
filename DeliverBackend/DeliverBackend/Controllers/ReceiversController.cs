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
    public class ReceiversController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Receivers
        public async Task<ActionResult> Index()
        {
            return View(await db.Receivers.ToListAsync());
        }

        // GET: Receivers/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receiver receiver = await db.Receivers.FindAsync(id);
            if (receiver == null)
            {
                return HttpNotFound();
            }
            return View(receiver);
        }

        // GET: Receivers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receivers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Phone,Address,CreatedAt,UpdatedAt,Deleted,Version")] Receiver receiver)
        {
            if (ModelState.IsValid)
            {
                db.Receivers.Add(receiver);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(receiver);
        }

        // GET: Receivers/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receiver receiver = await db.Receivers.FindAsync(id);
            if (receiver == null)
            {
                return HttpNotFound();
            }
            return View(receiver);
        }

        // POST: Receivers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Phone,Address,CreatedAt,UpdatedAt,Deleted,Version")] Receiver receiver)
        {
            if (ModelState.IsValid)
            {
                db.Entry(receiver).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(receiver);
        }

        // GET: Receivers/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receiver receiver = await db.Receivers.FindAsync(id);
            if (receiver == null)
            {
                return HttpNotFound();
            }
            return View(receiver);
        }

        // POST: Receivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Receiver receiver = await db.Receivers.FindAsync(id);
            db.Receivers.Remove(receiver);
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
