using Microsoft.AspNetCore.Mvc;
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

    public class DepartmantController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DepartmantController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index(int pageIndex = 1)
        {
            var item = _db.DataPhonelist.AsNoTracking().OrderBy(p => p.Id);
            var model = PagingList.Create(_db.Depatmantlist.ToList(), 10, pageIndex);
            return View(model);

        }


        //public IActionResult Index()
        //{

        //    //IEnumerable<DepartmantList> objlist = _db.Depatmantlist.Where (a=>a.Id == 2).ToList();
        //    IEnumerable<DepartmantList> objlist = _db.Depatmantlist.Where(a => a.Id == 2).ToList();
        //    return View(objlist);

        //}


        // Get For Create -------------
        public IActionResult Create()
        {
            return View();
        }

        // post For Create -------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DepartmantList obj)
        {
            if (ModelState.IsValid)
            {
                _db.Depatmantlist.Add(obj);
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
            var obj = _db.Depatmantlist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // post For Edit -------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DepartmantList obj)
        {
            if (ModelState.IsValid)
            {
                _db.Depatmantlist.Update(obj);
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
            var obj = _db.Depatmantlist.Find(id);
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
            var obj = _db.Depatmantlist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Depatmantlist.Remove(obj);
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
            var obj = _db.Depatmantlist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }



    }
}
