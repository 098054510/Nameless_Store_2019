using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nameless_Store_2019.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Send_Email()
        {
            return View();
        }
    }
}