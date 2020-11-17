using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var data = new List<Person>() {
                new Person() {Id=1, Name="johnson", Age=26 },
                new Person() {Id=2, Name="Nadia", Age=25 },
            };
            return View(data);
        }
    }
}