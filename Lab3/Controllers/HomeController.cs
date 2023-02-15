using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            //HttpContext.Session.SetString("Bottles", Request.Form["Bottles"]);
            ViewBag.Bottles = Request.Form["Bottles"];
            return View();
        }

        public IActionResult CreateStudent() => View();

        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {
            if (student.lastName != null && student.firstName != null && student.email != null && student.password != null && student.description != null && student.studentID != null)
            { return View(student); }
            return View("Error");

        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
