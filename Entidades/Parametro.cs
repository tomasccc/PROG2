using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1w2.Entidades
{
    internal class Parametro
    {
        public string nombre;
        public object valor;

        public string pNombre { get ; set; }
        public object pValor { get ; set; }
        public Parametro(string nombre,object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}
