using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanningMVC.Models;

namespace PlanningMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Planning()
        {

            List<ClsBanca> lstBancas = new List<ClsBanca>();

            ClsBanca lBanca1 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                strLado = "A",
                nroBanca = 1,
                largo = 15,
                ancho = 2,
                alto = 1
            };
            ClsBanca lBanca2 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                strLado = "A",
                nroBanca = 2,
                largo = 30,
                ancho = 1.2,
                alto = 1
            };
            ClsBanca lBanca3 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                strLado = "A",
                nroBanca = 3,
                largo = 34,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca4 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                strLado = "A",
                nroBanca = 4,
                largo = 22,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca5 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                strLado = "A",
                nroBanca = 1,
                largo = 20,
                ancho = 1.1,
                alto = 1
            };

            lstBancas.Add(lBanca1);
            lstBancas.Add(lBanca2);
            lstBancas.Add(lBanca3);
            lstBancas.Add(lBanca4);
            lstBancas.Add(lBanca5);

            return View(lstBancas);
        }

        [HttpPost]
        public ActionResult Sembrar()
        {
            ClsSiembra lSiembra = new ClsSiembra()
            {
                idSiembra = 1,
                codTipoInvernadero = 1,
                densidad = 1.11,
                totalPlantas = 100
            };

            return Json(lSiembra, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}