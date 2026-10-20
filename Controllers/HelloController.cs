using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class HelloController : Controller
    {
        public String Greeting()
        {
            return "Chao mung cac ban den voi mon hoc ASP.NET";
        }
        public String Welcome(int id, string name)
        {
            return $"Xin chao {id} - {name}, chuc ban hoc tot";
        }

        public IActionResult Welcome1(int ttt, string name)
        {
            ViewBag.Id = ttt;
            ViewData["Name"] = name;
            return View();
        }

    }
}