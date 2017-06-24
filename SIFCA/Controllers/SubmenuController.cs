using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIFCA.Controllers
{
    public class SubmenuController : Controller
    {
        // GET: Submenu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewCaja()
        {
            ViewBag.Message = "Datos de Caja.";

            return View();
        }

        public ActionResult ViewSocio()
        {
            ViewBag.Message = "Datos de los Afiliados";

            return View();
        }

        public ActionResult ViewContabilidad()
        {
            ViewBag.Message = "Datos Contables";

            return View();
        }

        public ActionResult ViewOrganizacion()
        {
            ViewBag.Message = "Organizaciones";

            return View();
        }

        public ActionResult ViewProveedores()
        {
            ViewBag.Message = "Datos de los Proveedores";

            return View();
        }
        public ActionResult ViewTesoreria()
        {
            ViewBag.Message = "Tesoreria";

            return View();
        }
      


    }
}