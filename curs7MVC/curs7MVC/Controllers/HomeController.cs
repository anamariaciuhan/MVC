using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace curs7MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [ActionName("About")]

       public ActionResult SomeMethodName()
        {
            return View();
        }
        public int Calc()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                
                sum += i;
            }
            return sum;
        }

        public int DisplayCalc()
        {
            return Calc();
        }
        [HttpPost()]
        public string VerbsTest()
        {
            return "Hello";
        }
    }
}