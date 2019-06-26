using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace PlanningMVC.Models
{
    public class ClsBanca
    {
        public int nroInvernadero { get; set; }
        public int codTipoInvernadero { get; set; }
        public string strLado { get; set; }
        [DisplayName("Banca")]
        public int nroBanca { get; set; }
        public double largo { get; set; }
        public double ancho { get; set; }
        public double alto { get; set; }
        public double areaAproximada { get { return Math.Round(this.largo * this.ancho,0); } }
        public double area { get { return Math.Round(this.largo * this.ancho, 2); } }
        public double areaExcedente {
            get {
                if (Math.Abs(this.area % 1) <= (Double.Epsilon * 100))
                {
                    return 0;  
                }else
                {
                    return Math.Round(area - Math.Round(area, 0), 2);                   
                }
            } }

    }
}