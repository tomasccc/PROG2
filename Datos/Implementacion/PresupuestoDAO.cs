using Carpinteria1w2.Datos.Interfaz;
using Carpinteria1w2.Entidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1w2.Datos.Implementacion
{
    internal class PresupuestoDAO : IPresupuestoDAO
    {
        public bool Actualizar(Presupuesto oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int numero)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Presupuesto oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public Presupuesto ObtenerPresupuestoPorNro(int numero)
        {
            throw new NotImplementedException();
        }

        public List<Presupuesto> ObtenerPresupuestosConFiltro(DateTime desde, DateTime hasta, string cliente)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos= new List<Producto>();
            DataTable dt = HelperDAO.getInstance().Consultar("SP_CONSULTAR_PRODUCTOS");
            //mapear un registro de la tabla a un objeto del modelo de dominio
            foreach (DataRow dr in dt.Rows)
            {
                int nro = int.Parse(dr["id_producto"].ToString());
                string nom = dr["n_producto"].ToString();
                double precio = double.Parse(dr["precio"].ToString());
                bool activo = dr["activo"].ToString().Equals("S"); //si es S tome esa fila como cierta
                Producto p = new Producto(nro,nom,precio);
                p.Activo = activo;
                productos.Add(p);
            }
            return productos;
        }

        public int ObtenerProximoPresupuesto()
        {
            return HelperDAO.getInstance().ConsultarEscalar("SP_PROXIMO_ID", "@next");
        }
    }
}
