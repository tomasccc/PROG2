using Carpinteria1w2.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1w2.Datos.Interfaz
{
    public interface IPresupuestoDAO
    {
        /*aca va lo que deberia hacer un presupuesto para un patron DAO*/
        //mantener informacion

        int ObtenerProximoPresupuesto();
        List<Producto> ObtenerProductos();
        bool Crear(Presupuesto oPresupuesto);
        bool Actualizar(Presupuesto oPresupuesto);
        bool Borrar(int numero);
        List<Presupuesto> ObtenerPresupuestosConFiltro(DateTime desde,DateTime hasta,string cliente);
        Presupuesto ObtenerPresupuestoPorNro(int numero);
    }
}
