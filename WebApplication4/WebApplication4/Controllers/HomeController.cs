using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using Microsoft.AspNetCore.Authorization;
using WebApplication4.Infrastructure;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var blogs = MappingModels.MapListDatabaseBlog(DbConnection.DisplayAllBlogs());
            if(Request.Cookies.ContainsKey("userId"))
                return View(blogs);
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Account()
        {
            var user = MappingModels.MapDatabaseUser(DbConnection.GetUser(Request.Cookies["userId"]));
            return View(user);
        }

        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog myBlog)
        {
            myBlog.UserId = Int32.Parse(Request.Cookies["userId"]);
            DbConnection.SaveBlog(MappingModels.MapModelBlog(myBlog));
            return View();
        }

        public IActionResult DisplayBlog()
        {
            var bl = DbConnection.DisplayBlog(Request.Cookies["userId"]).ToList();
            var blogs = MappingModels.MapListDatabaseBlog(bl);
            return View(blogs);
        }

        public IActionResult EditBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            return Content($"{blog.Id} {blog.Headline} {blog.IsOpen} {blog.UserId}");
            DbConnection.EditBlog(MappingModels.MapModelBlog(blog));
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
