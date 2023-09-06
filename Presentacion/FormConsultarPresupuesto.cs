using Carpinteria1w2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria1w2
{
    public partial class Consultar : Form
    {
        //HACER BOTON ELIMINAR DENTRO DE ACCIONES EN EL DATAGRIDVIEW
        DBHelper dbHelper;
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            dtpFechadesde.Value=DateTime.Now.AddDays(-7);
            dtpFechahasta.Value=DateTime.Now;
            dbHelper = new DBHelper();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            //validar campos de carga!
            List<Entidades.Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@fecha_desde",dtpFechadesde.Value.ToString("aaaaMMdd")));
            parametros.Add(new Parametro("@fecha_hasta",dtpFechadesde.Value.ToString("aaaaMMdd")));
            parametros.Add(new Parametro("@cliente",txtcliente.Text));

            DataTable dt = dbHelper.ConsultarConParametros("SP_CONSULTAR_PRESUPUESTOS", parametros);

            foreach (DataRow fila in dt.Rows)
            {
                DGVpresupuestos.Rows.Add(new object[] { fila["presupuesto_nro"].ToString(),
                    fila["fecha"].ToString(),
                    fila["cliente"].ToString(),
                    fila["total"].ToString() }
                    );

                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
