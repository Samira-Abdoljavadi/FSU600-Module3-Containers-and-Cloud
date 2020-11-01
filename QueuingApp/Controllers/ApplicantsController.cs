using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QueuingApp.Services;
using QueuingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QueuingApp.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly ApplicantsService _applicantsService;

        public ApplicantsController(ApplicantsService applicantsService)
        {
            _applicantsService = applicantsService;
        }

        // GET: ApplicantsController
        public ActionResult Index()
        {
            return View(_applicantsService.Get());
        }

        // GET: ApplicantsController/Details/5
        public ActionResult Details(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var applicants = _applicantsService.Get(Id);
            if (applicants == null)
            {
                return NotFound();
            }
            return View(applicants);
        }

        // GET: ApplicantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Applicants applicants)
        {
            if (ModelState.IsValid)
            {
                applicants.id = new Random().Next();
                _applicantsService.Create(applicants);
                return RedirectToAction(nameof(Index));
            }
            return View(applicants);
        }

        // GET: ApplicantsController/Edit/5
        public ActionResult Edit(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var applicants = _applicantsService.Get(Id);
            if (applicants == null)
            {
                return NotFound();
            }
            return View(applicants);
        }

        // POST: ApplicantsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string Id, Applicants applicants)
        {
            applicants.objectId = Id;
            applicants.id = new Random().Next();
            _applicantsService.Update(Id, applicants);
            return RedirectToAction(nameof(Index));
        }

        // GET: ApplicantsController/Delete/5
        public ActionResult Delete(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var applicants = _applicantsService.Get(Id);
            if (applicants == null)
            {
                return NotFound();
            }
            return View(applicants);
        }

        // POST: ApplicantsController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string Id)
        {
            try
            {
                var applicants = _applicantsService.Get(Id);

                if (applicants == null)
                {
                    return NotFound();
                }

                _applicantsService.Remove(applicants.objectId);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
