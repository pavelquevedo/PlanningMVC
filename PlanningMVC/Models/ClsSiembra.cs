using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanningMVC.Models
{
    public class ClsSiembra
    {
        public int idSiembra { get; set; }
        public int codTipoInvernadero { get; set; }
        public int totalPlantas { get; set; }
        public double densidad { get; set; }
        public string color { get; set; }
        public double area
        {
            get
            {
                return Math.Round(totalPlantas * densidad, 2);
            }

        }
    }
}