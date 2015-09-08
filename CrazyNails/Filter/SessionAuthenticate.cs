using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CrazyNails.Filter
{
	public class SessionAuthenticate:ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);
			if (filterContext.HttpContext.Session["Account"]==null)
			{
				//filtercontext.result = new redirecttorouteresult(						// 會自動導到另一個action
				//	new routevaluedictionary { { "controller", "login" }, { "action", "index2" } });

				//filterContext.Result = new JsonResult
				//{
				//	JsonRequestBehavior = JsonRequestBehavior.AllowGet,					// 回傳包字串的物件
				//	Data = new { result = "請先登入" }
				//};
				return;
			}

			
		}
	}
}