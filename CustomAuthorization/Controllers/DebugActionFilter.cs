using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CustomAuthorization.Controllers
{
    public class CustomActionFilter :  ActionFilterAttribute
    {
        public int  InputParameter { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var x = this.InputParameter;

            filterContext.Result = new JsonResult(new { HttpStatusCode.Unauthorized });
        }
    }
}
