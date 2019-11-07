using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_tut.Controllers
{
    public class HelloWorldController:Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"]="Hello, this is my view";
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"]="Hello, welcome to HelloWorld Application";
            return View();
        }
    }
}