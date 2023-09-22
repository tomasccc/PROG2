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

namespace Carpinteria1w2.Presentacion
{
    public partial class FormDetallePresupuesto : Form
    {
        DBHelper dbHelper = new DBHelper();
        int nropresupuesto;
       

        public FormDetallePresupuesto(int p)
        {
            InitializeComponent();
            nropresupuesto = p;
        }
        private void FormDetallePresupuesto_Load(object sender, EventArgs e)
        {
            List<Parametro> list = new List<Parametro>();
            list.Add(new Parametro("@presupuesto_nro",nropresupuesto));
            DataTable dt = dbHelper.ConsultarConParametros("SP_CONSULTAR_DETALLES_PRESUPUESTO",list);
            bool primero = true;
            foreach (DataRow fila in dt.Rows)
            {
                if (primero)
                {
                    txtCliente.Text = fila["cliente"].ToString();
                    txtFecha.Text = fila["fecha"].ToString();
                    txtTotal.Text = fila["total"].ToString();
                    txtDto.Text = fila["descuento"].ToString();
                    primero = false;
                }
                dgvDetalles.Rows.Add(new object[] { fila["n_producto"].ToString(),
                    fila["precio"].ToString(),
                    fila["cantidad"]
                });
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
