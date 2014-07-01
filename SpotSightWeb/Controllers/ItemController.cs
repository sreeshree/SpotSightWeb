using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpotSightWeb.Models;
using SpotSightWeb.DAL;
using SpotSightWeb.ViewModel;

namespace SpotSightWeb.Controllers
{
    public class ItemController : Controller
    {
        private SpotSightContext db = new SpotSightContext();

        // GET: /Item/
        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }

        // GET: /Item/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: /Item/Create
        public ActionResult Create()
        {
         //   Category Categories = db.Categories.Find(id);
           // SelectedItem items = new SelectedItem();
           // items.cate
            ViewBag.catgories = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: /Item/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SelectedItem newItem)
        {
            Item currentItem = new Item();

            currentItem.UUId = newItem.UUId;
            currentItem.Title = newItem.Title;
            currentItem.MajorNumber = newItem.MajorNumber;
            currentItem.MinorNumber = newItem.MinorNumber;
            currentItem.Description = newItem.Description;
            currentItem.ImageUrl = newItem.ImageUrl;
            currentItem.VideoUrl = newItem.VideoUrl;
            currentItem.AudioUrl = newItem.AudioUrl;
            currentItem.IsPush = newItem.IsPush;
            currentItem.categoryId = newItem.categoryId;

            if (ModelState.IsValid)
            {
                db.Items.Add(currentItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: /Item/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: /Item/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UUId,MajorNumber,MinorNumber,Title,Description,ImageUrl,VideoUrl,AudioUrl,IsPush,categoryId")] Item item)
        {
            if (ModelState.IsValid)
            {
               Item Tempitem = db.Items.Find(item.Id);
                item.categoryId = Tempitem.categoryId;
                db.Entry(Tempitem).CurrentValues.SetValues(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: /Item/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: /Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ViewItem(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item Items = db.Items.Find(id);
            Category Categories = db.Categories.Find(Items.categoryId);
            SelectedItem DisplayItem = new SelectedItem();
            DisplayItem.Name = Categories.Name;
            DisplayItem.Description = Categories.Description;
            DisplayItem.ImageUrl = Categories.ImageUrl;
            DisplayItem.Lat = Categories.Lat;
            DisplayItem.Long = Categories.Long;
            DisplayItem.UUId = Items.UUId;
            DisplayItem.MajorNumber = Items.MajorNumber;
            DisplayItem.MinorNumber = Items.MinorNumber;
            DisplayItem.Title = Items.Title;
            DisplayItem.ItemDescription = Items.Description;
            DisplayItem.ItemImageUrl = Items.ImageUrl;
            DisplayItem.VideoUrl = Items.VideoUrl;
            DisplayItem.AudioUrl = Items.AudioUrl;
            DisplayItem.IsPush = Items.IsPush;
            DisplayItem.categoryId = Items.categoryId;

            if (Items == null)
            {
                return HttpNotFound();
            }
            return View(DisplayItem);
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
