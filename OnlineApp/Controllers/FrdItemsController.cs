﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineApp.Models;
using OnlineApp.ModelData;

namespace OnlineApp.Controllers
{
    [Authorize]
    public class FrdItemsController : Controller
    {
        private LIVEEntities db = new LIVEEntities();

        // GET: FrdItems
        public ActionResult Index()
        {
            var w = (from y in db.sUsers
                     where y.UserID.ToString() == User.Identity.Name
                     select new { y.PlantNo }).FirstOrDefault();
            var wn = db.sPlants.Where(x => x.PlantNo == w.PlantNo).FirstOrDefault();
            var cust = db.sBenificiaries.Where(x => x.PlantID == wn.PlantNo && x.Status == "Y").Select(x => new { Text = x.BenificiaryName + " , " + x.BenificiaryID, Value = x.BenificiaryID }).OrderBy(e => e.Text).ToList();
            ViewBag.PlantCode = wn.PlantNo;
            ViewBag.WarehouseIDLogin = wn.PlantName;
            ViewBag.ItemType = new SelectList(db.sParams.Where(c => c.StartCode == 400001), "IDCode", "Description");
            ViewBag.ItemTypeCode = new SelectList(db.sParams.Where(c => c.StartCode == 500001), "IDCode", "Description");
            ViewBag.ItemUnitCode = new SelectList(db.sUnits, "UnitID", "UnitName");
            ViewBag.ItemMachineCode = new SelectList(db.FrdMachines, "MachineID", "MachineName");
            int value = db.FrdItems.Max(a => a.ItemNo);
            int num = value;

            ItemVM sup = new ItemVM
            {
                ItemNo = (num + 1),

            };
            return View(sup);
        }
        [HttpPost]
        public ActionResult CreateItem(ItemVM item)
        {
            using (LIVEEntities db = new LIVEEntities())
            {
                FrdItem nw = new FrdItem();
                nw.ItemNo = item.ItemNo;
                nw.ItemCode = item.ItemCode;
                nw.ItemName = item.ItemName;
                nw.ItemDescription = item.ItemDescription;
                nw.ItemType = item.ItemType;
                nw.ItemTypeCode = item.ItemTypeCode;
                nw.ItemUnitCode = item.ItemUnitCode;
                nw.PlantCode = item.PlantCode;
                nw.ItemMachineCode = item.ItemMachineCode;
                nw.UnitPrice = item.UnitPrice;
                nw.TaxFlag = "Y";
                nw.ConvertValue = item.ConvertValue;
                nw.UseFor = "User recomended";
                nw.Show = "N";
                nw.CreateBy = Session["Name"].ToString();
                nw.CreateDate = DateTime.Now;
                db.FrdItems.Add(nw);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
        }

        // GET: FrdItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrdItem frdItem = db.FrdItems.Find(id);
            if (frdItem == null)
            {
                return HttpNotFound();
            }
            return View(frdItem);
        }

        // GET: FrdItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FrdItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ItemNo,ItemCode,ItemName,ItemDescription,ItemType,ItemTypeCode,ItemUnitCode,PlantCode,ItemMachineCode,UnitPrice,TaxFlag,ConvertValue,UseFor,Show,CreateBy,CreateDate")] FrdItem frdItem)
        {
            if (ModelState.IsValid)
            {
                db.FrdItems.Add(frdItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(frdItem);
        }

        // GET: FrdItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrdItem frdItem = db.FrdItems.Find(id);
            if (frdItem == null)
            {
                return HttpNotFound();
            }
            return View(frdItem);
        }

        // POST: FrdItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ItemNo,ItemCode,ItemName,ItemDescription,ItemType,ItemTypeCode,ItemUnitCode,PlantCode,ItemMachineCode,UnitPrice,TaxFlag,ConvertValue,UseFor,Show,CreateBy,CreateDate")] FrdItem frdItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(frdItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(frdItem);
        }

        // GET: FrdItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrdItem frdItem = db.FrdItems.Find(id);
            if (frdItem == null)
            {
                return HttpNotFound();
            }
            return View(frdItem);
        }

        // POST: FrdItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FrdItem frdItem = db.FrdItems.Find(id);
            db.FrdItems.Remove(frdItem);
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
