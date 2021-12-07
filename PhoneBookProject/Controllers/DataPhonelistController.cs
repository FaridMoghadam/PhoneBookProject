using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneBookProject.Data;
using PhoneBookProject.Models;
using ReflectionIT.Mvc.Paging;
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

        public IActionResult Index(int pageIndex = 1)
        {
            var item = _db.DataPhonelist.AsNoTracking().OrderBy (p => p.Id);
            var model = PagingList.Create(_db.DataPhonelist.ToList(), 5, pageIndex);
            return View(model);
        }


        // Get For Create
        public IActionResult Create()
        {
            var DepartmantListlist = (from DepartmantList in _db.Depatmantlist
                                      select new SelectListItem()
                                      {
                                          Text = DepartmantList.Name,
                                          Value = DepartmantList.Name.ToString()
                                      }).ToList();
            DepartmantListlist.Insert(0, new SelectListItem()
            {
                Text = "---- انتخاب کنید ----",
                Value = string.Empty
            });

            ViewBag.ListOfDepartmant = DepartmantListlist;

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
