using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1w2.Entidades
{
    public class Parametro
    {
        public string nombre;
        public object valor;

        public string pNombre { get { return nombre; } set { nombre = value; } }
        public object pValor { get { return valor; } set { valor = value; } }
        public Parametro(string nombre,object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }

        public Parametro(object valor)
        {
            this.valor = valor;
        }
    }
}
