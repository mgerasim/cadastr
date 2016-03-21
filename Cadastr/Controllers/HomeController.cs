using Cadastr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cadastr.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Cadastrentity> theCadastrList = Cadastrentity.GetAll(); ;
            return View(theCadastrList);
        }

    }
}
