using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fechas
{
    public class Fechas
    {
        public Int64 idcompromiso { get; set; }
        public String nomcompromiso { get; set; }
        public String plazo { get; set; }
        public String fdepago { get; set; }
        public String fcaducidad { get; set; }
        public String valordecuota { get; set; }
        public String pago { get; set; }
        public String formadepago { get; set;}
        public String cantidad { get; set; }
        public String datos { get; set; }
      public Fechas() { }

      public Fechas(Int64 pid, String pnombre, String pplazo, String pfplazo, String pfcaducidad, String pvalordecuota, String ppago, String pformadepago, String pcantidad, String pdatos)

      {
          this.idcompromiso = pid;
          this.nomcompromiso = pnombre;
          this.plazo = pplazo;
          this.fdepago = pfplazo;
          this.fcaducidad = pfcaducidad;
          this.valordecuota = pvalordecuota;
          this.pago = ppago;
          this.formadepago = pformadepago;
          this.cantidad = pcantidad;
          this.datos = pdatos;
      
      }

    }
}
