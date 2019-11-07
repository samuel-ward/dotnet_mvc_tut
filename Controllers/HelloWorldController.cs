using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

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

        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

/*      
        public string Welcome(string name, int numTimes=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        } 
*/
    }
}