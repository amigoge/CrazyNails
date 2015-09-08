using CrazyNails.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrazyNails.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
		[SessionAuthenticate]
        public ActionResult Index()
        {
            return View();
        }


		public ActionResult Index2() 
		{
			return PartialView();
		}
    }
}