using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labb_för_webbutveckling.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/MinView
        [HttpGet]
        public ViewResult Index()
        {
            return View("MinView");
        }

        /*
        // POST: /Home/Answer
        [HttpPost]
        public ActionResult Answer(int sign, float numberOne, float numberTwo)
        {
            switch (sign)
            {
                case 0:
                    {
                        ViewBag.send = numberOne + numberTwo;
                        break;
                    }
                case 1:
                    {
                        ViewBag.send = numberOne - numberTwo;
                        break;
                    }
                case 2:
                    {
                        ViewBag.send = numberOne * numberTwo;
                        break;
                    }
                case 3:
                    {
                        ViewBag.send = numberOne / numberTwo;
                        break;
                    }
            }

            return View("Answer");       
        }*/

        /*
        // GET: /Home/Answer
        [HttpGet]
        public ActionResult Answer(int sign, float numberOne, float numberTwo)
        {
            switch (sign)
            {
                case 0:
                    {
                        ViewBag.send = numberOne + numberTwo;
                        break;
                    }
                case 1:
                    {
                        ViewBag.send = numberOne - numberTwo;
                        break;
                    }
                case 2:
                    {
                        ViewBag.send = numberOne * numberTwo;
                        break;
                    }
                case 3:
                    {
                        ViewBag.send = numberOne / numberTwo;
                        break;
                    }
            }
            return View("Answer");
        }
        */

        // GET: /Home/Answer
        [HttpGet]
        public ActionResult Answer()
        {
            int sign = Convert.ToInt16(Request.Form["sign"]);
            double numberOne = Convert.ToDouble(Request.Form["numberOne"]);
            double numberTwo = Convert.ToDouble(Request.Form["numberTwo"]);
       
            switch (sign)
            {
                case 0:
                    {
                        ViewBag.send = numberOne + numberTwo;
                        break;
                    }
                case 1:
                    {
                        ViewBag.send = numberOne - numberTwo;
                        break;
                    }
                case 2:
                    {
                        ViewBag.send = numberOne * numberTwo;
                        break;
                    }
                case 3:
                    {
                        ViewBag.send = numberOne / numberTwo;
                        break;
                    }
            }
            return View("Answer");
        }
    }
}