using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace iPhoneRepair.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/index.html")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/aboutme.html")]
        public IActionResult AboutMe()
        {
            return View();
        }
        [Route("/aboutus.html")]
        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("/findus.html")]
        public IActionResult FindUs()
        {
            return View();
        }
        [Route("/gaming.html")]
        public IActionResult Gaming()
        {
            return View();
        }
        [Route("/repairs.html")]
        public IActionResult Repairs()
        {
            return View();
        }
        [Route("/silenttsolutions.html")]
        public IActionResult SilentTSolutions()
        {
            return View();
        }
        [Route("/training.html")]
        public IActionResult Training()
        {
            return View();
        }
        [Route("/warranty.html")]
        public IActionResult Warranty()
        {
            return View();
        }
		[Route("/testimonials.html")]
		public IActionResult Testimonials()
		{
			return View();
		}
	
    }
}
