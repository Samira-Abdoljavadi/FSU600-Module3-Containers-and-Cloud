using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QueuingApp.Models;
using QueuingApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace QueuingApp.Controllers
{
    public class ApartmentsController : Controller
    {
        private readonly ApartmentsService _apartmentsService;

        public ApartmentsController(ApartmentsService apartmentsService)
        {
            _apartmentsService = apartmentsService;
        }

        // GET: ApartmentsController
        public ActionResult Index()
        {
            return View(_apartmentsService.Get());
        }

        // GET: ApartmentsController/Details/5
        public ActionResult Details(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var apartments = _apartmentsService.Get(Id);
            if (apartments == null)
            {
                return NotFound();
            }
            return View(apartments);
        }

        // GET: ApartmentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApartmentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Apartments apartments)
        {
            if (ModelState.IsValid)
            {
                apartments.id = new Random().Next();
                _apartmentsService.Create(apartments);
                return RedirectToAction(nameof(Index));
            }
            return View(apartments);
        }

        // GET: ApartmentsController/Edit/5
        public ActionResult Edit(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var apartments = _apartmentsService.Get(Id);
            if (apartments == null)
            {
                return NotFound();
            }
            return View(apartments);
        }

        // POST: ApartmentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string Id, Apartments apartments)
        {
            apartments.objectId = Id;
            apartments.id = new Random().Next();
            _apartmentsService.Update(Id, apartments);
            return RedirectToAction(nameof(Index));
        }

        // GET: ApartmentsController/Delete/5
        public ActionResult Delete(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var apartments = _apartmentsService.Get(Id);
            if (apartments == null)
            {
                return NotFound();
            }
            return View(apartments);
        }

        // POST: ApartmentsController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string Id)
        {
            try
            {
                var apartments = _apartmentsService.Get(Id);

                if (apartments == null)
                {
                    return NotFound();
                }

                _apartmentsService.Remove(apartments.objectId);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
