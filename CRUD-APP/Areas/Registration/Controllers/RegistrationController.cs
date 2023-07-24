using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_APP.Areas.Registration.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration/Registration
        public ActionResult Index()
        {
            return View();
        }
    }
}