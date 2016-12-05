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

        //[RangeException] - Using the RangeException Attribute in the "Infrastructure" folder
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return String.Format("The id value is: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        //[CustomAction]
        [ProfileAction]
        public string FilterTest()
        {
            return "This is the FilterTest action";
        }
    }
}