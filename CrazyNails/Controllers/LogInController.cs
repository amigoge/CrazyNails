using CrazyNails.DAL;
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
			var db = new Context();
			var a = db.NailSpecialists.ToList();
            return View();
        }


		public ActionResult Index2() 
		{
			return PartialView();
		}
    }
}