using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class hello : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public string Welcome(string name ,int nuntimes =1 )
        //{
        //    return HtmlEncoder.Default.Encode($"hello {name},nuntimes is {nuntimes} ");
        //}
        public IActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewData["Id"] = id;
            return View();
        }

    }
}
