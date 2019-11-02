using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ef;
using Microsoft.AspNetCore.Mvc;
using WebApplication_aspdotnetcore.Models;

namespace WebApplication_aspdotnetcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly BloggingContext _context;

        public HomeController(BloggingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //    var ddf = _context.Blogs


            //    Severity Code    Description Project File Line    Suppression State
            //   Error CS0012  The type 'DbSet<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'.WebApplication11_ef C: 


            return View();
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
