using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria1w2.Entidades
{
    public class Presupuesto
    {
        public Presupuesto()
        {
            Detalles = new List<DetallePresupuesto>();
        }
        public int PresupuestoNro { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public double CostoMO { get; set; }

        public double Descuento { get; set; }

        public DateTime FechaBaja { get; set; }

        public List<DetallePresupuesto> Detalles { get; set; }

        public Presupuesto(int presupuestoNro, DateTime fecha, string cliente, double costoMO, double descuento, DateTime fechaBaja, List<DetallePresupuesto> detalles)
        {
            Detalles = new List<DetallePresupuesto>();
            Detalles = detalles;
            PresupuestoNro = presupuestoNro;
            Fecha = fecha;
            Cliente = cliente;
            CostoMO = costoMO;
            Descuento = descuento;
            FechaBaja = fechaBaja;
            Detalles = detalles;
        }

        public double CalcularTotal()
        {
            double total = 0;
            for(int i = 0; i < Detalles.Count; i++)
            {
                total += Detalles[i].CalcularSubTotal();
            }
            return total;
        }

    }
}
