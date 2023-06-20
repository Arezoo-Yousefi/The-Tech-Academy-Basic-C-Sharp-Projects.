using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,Quote,CoverageType")] Insuree insuree)
        {
            ModelState["Quote"].Errors.Clear();
            
            
            if (ModelState.IsValid)
            {
                insuree.Quote = QuoteCalculate(insuree.DateOfBirth, insuree.CarYear, insuree.CarMake, insuree.CarModel, insuree.SpeedingTickets, insuree.DUI, insuree.CoverageType);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,Quote,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = QuoteCalculate(insuree.DateOfBirth, insuree.CarYear, insuree.CarMake, insuree.CarModel, insuree.SpeedingTickets, insuree.DUI, insuree.CoverageType);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        
        public ActionResult Admin()
        {


            return View(db.Insurees.Select(x=> new MinimizedInsurre { FirstName = x.FirstName, LastName = x.LastName, EmailAddress = x.EmailAddress, Quote = x.Quote}).ToList());
            
        }
        private decimal QuoteCalculate(DateTime dateOfBirth, int carYear, string carMake, string carModel, int speedingTicket, bool dui, bool coverageType)
        {
            decimal totalQuote = 50;
            int clientAge = DateTime.Now.Year - dateOfBirth.Year;
            if(clientAge <= 18)
            {
                totalQuote += 100;
            }
            else if(clientAge>=19 && clientAge <= 25)
            {
                totalQuote += 50;
            }
            else if(clientAge >= 26)
            {
                totalQuote += 25;
            } 

            if (carYear <= 2000)
            {
                totalQuote += 25;
            }
            else if(carYear >= 2015)
            {
                totalQuote += 25;
            }

            if(carMake == "Porsche")
            {
                totalQuote += 25;
                if(carModel == "911 Carrera")
                {
                    totalQuote += 25;
                }
            }

            totalQuote += speedingTicket * 10;
            if(dui)
            {
                totalQuote += totalQuote * 0.25M;
            }

            if (coverageType)
            {
                totalQuote += totalQuote * 0.5M;
            }
            

            return totalQuote;
        }
    }
}
