using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneBookProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ReflectionIT.Mvc.Paging;
using System.Threading.Tasks;
using PhoneBookProject.Data;
using Microsoft.EntityFrameworkCore;

namespace PhoneBookProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;



        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index(int pageIndex = 1)
        {
            var item = _db.DataPhonelist.AsNoTracking().OrderBy(p => p.Id);
            var model = PagingList.Create(_db.DataPhonelist.ToList(), 1000, pageIndex);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
