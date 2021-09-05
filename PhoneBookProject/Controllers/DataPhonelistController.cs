using Microsoft.AspNetCore.Mvc;
using PhoneBookProject.Data;
using PhoneBookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PhoneBookProject.Controllers
{
    public class DataPhonelistController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DataPhonelistController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<DataPhonelist> obj = _db.DataPhonelist;
            return View(obj);
        }

        // Get For Create
        public IActionResult Create()
        {
           return View();
        }

        // post For Create -------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DataPhonelist obj)
        {

            if (ModelState.IsValid)
            {

                _db.DataPhonelist.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("index");
            }

            return View(obj);

        }


        // Get For Edit -------------
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.DataPhonelist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // post For Edit -------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DataPhonelist obj)
        {
            if (ModelState.IsValid)
            {
                _db.DataPhonelist.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(obj);
        }


        // Get For Delete -------------
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.DataPhonelist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // post For Delete  -------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.DataPhonelist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.DataPhonelist.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("index");

        }


        // Get For View -------------
        public IActionResult view(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.DataPhonelist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }



    }

}
