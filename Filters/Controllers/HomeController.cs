using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        //[CustomAuth(true)]
        [Authorize(Users = "admin")]
        public string Index()
        {
            return "This is the index action on the home controller";
        }

        [GoogleAuth]
        public string List()
        {
            return "This is the List action on the home controller";
        }
    }
}