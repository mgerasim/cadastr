using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cadastr.Controllers
{
    public class SchemaController : Controller
    {
        //
        // GET: /Schema/

        public ActionResult Update()
        {
            try
            {
                Common.NHibernateHelper.UpdateSchema();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                if (ex.InnerException != null)
                {
                    err += ex.InnerException.Message;
                }
                return Content(err);
            }
            return Content("Схема обнавлена");
        }

    }
}
