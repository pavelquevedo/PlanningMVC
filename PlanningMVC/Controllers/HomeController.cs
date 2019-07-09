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
            List<ClsSiembra> lstSiembra = new List<ClsSiembra>();
            ClsSiembra lSiembra = new ClsSiembra()
            {
                idSiembra = 1,
                codTipoInvernadero = 1,
                densidad = 1.11,
                totalPlantas = 50,
                color = "red"
            };

            ClsSiembra lSiembra2 = new ClsSiembra()
            {
                idSiembra = 2,
                codTipoInvernadero = 1,
                densidad = 0.7,
                totalPlantas = 25,
                color = "green"
            };

            ClsSiembra lSiembra3 = new ClsSiembra()
            {
                idSiembra = 3,
                codTipoInvernadero = 1,
                densidad = 0.7,
                totalPlantas = 15,
                color = "yellow"
            };

            ClsSiembra lSiembra4 = new ClsSiembra()
            {
                idSiembra = 4,
                codTipoInvernadero = 1,
                densidad = 0.6,
                totalPlantas = 30,
                color = "lightblue"
            };

            lstSiembra.Add(lSiembra);
            lstSiembra.Add(lSiembra2);
            lstSiembra.Add(lSiembra3);
            lstSiembra.Add(lSiembra4);

            Session["Siembras"] = lstSiembra;


            return View();
        }

        public ActionResult Planning()
        {

            List<ClsBanca> lstBancas = new List<ClsBanca>();

            ClsBanca lBanca1 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 1,
                nroBanca = 1,
                largo = 34,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca2 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 1,
                nroBanca = 2,
                largo = 30,
                ancho = 1.2,
                alto = 1
            };
            ClsBanca lBanca3 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 1,
                nroBanca = 3,
                largo = 34,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca4 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 1,
                nroBanca = 4,
                largo = 22,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca5 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 1,
                nroBanca = 5,
                largo = 20,
                ancho = 1.1,
                alto = 1
            };

            ClsBanca lBanca6 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 2,
                nroBanca = 6,
                largo = 34,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca7 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 2,
                nroBanca = 7,
                largo = 30,
                ancho = 1.2,
                alto = 1
            };
            ClsBanca lBanca8 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 2,
                nroBanca = 8,
                largo = 34,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca9 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 2,
                nroBanca = 9,
                largo = 22,
                ancho = 1.1,
                alto = 1
            };
            ClsBanca lBanca10 = new ClsBanca()
            {
                nroInvernadero = 1,
                codTipoInvernadero = 1,
                ladoInvernadero = 2,
                nroBanca = 10,
                largo = 20,
                ancho = 1.1,
                alto = 1
            };

            lstBancas.Add(lBanca1);
            lstBancas.Add(lBanca2);
            lstBancas.Add(lBanca3);
            lstBancas.Add(lBanca4);
            lstBancas.Add(lBanca5);
            lstBancas.Add(lBanca6);
            lstBancas.Add(lBanca7);
            lstBancas.Add(lBanca8);
            lstBancas.Add(lBanca9);
            lstBancas.Add(lBanca10);

            return View(lstBancas);
        }

        [HttpPost]
        public ActionResult Sembrar(int id){

            List<ClsSiembra> lstSiembra = (List<ClsSiembra>)Session["Siembras"];

            return Json(lstSiembra.Where(m => m.idSiembra == id).First(), JsonRequestBehavior.AllowGet);                                
        }

        [HttpGet]
        public ActionResult fncObtenerSiembra(int id) {
            List<ClsSiembra> lstSiembra = (List<ClsSiembra>)Session["Siembras"];

            return Json(lstSiembra.Where(m => m.idSiembra == id).First(), JsonRequestBehavior.AllowGet);
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