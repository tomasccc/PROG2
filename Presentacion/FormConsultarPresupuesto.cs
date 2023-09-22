using Carpinteria1w2.Entidades;
using Carpinteria1w2.Presentacion;
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
        DBHelper dbHelper;
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            dtpFechadesde.Value=DateTime.Now.AddDays(-90);
            dtpFechahasta.Value=DateTime.Now;
            dbHelper = new DBHelper();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                CargarDataGrid();
            }    
        }
        private bool Validar()
        {
            if(dtpFechadesde.Value>DateTime.Now)
            {
                MessageBox.Show("No puede buscar un presupuesto fechado en una fecha en la que no estamos!","CONSULTAR",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            if (dtpFechahasta.Value < dtpFechadesde.Value)
            {
                MessageBox.Show("(Fecha Desde) no puede tener una fecha mayor a (Fecha Hasta)","CONSULTAR",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            if (txtcliente.Text == null) {
                MessageBox.Show("Debe ingresar un cliente", "CONSULTAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void CargarDataGrid()
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@fecha_desde", dtpFechadesde.Value));
            parametros.Add(new Parametro("@fecha_hasta", dtpFechahasta.Value));
            parametros.Add(new Parametro("@cliente", txtcliente.Text));
            DGVpresupuestos.Rows.Clear();
            DataTable dt = dbHelper.ConsultarConParametros("SP_CONSULTAR_PRESUPUESTOS", parametros);

            foreach (DataRow fila in dt.Rows)
            {
                DGVpresupuestos.Rows.Add(new object[] {
                    fila["presupuesto_nro"].ToString(),
                    fila["fecha"].ToString(),
                    fila["cliente"].ToString(),
                    fila["total"].ToString(), }
                    );
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DGVpresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVpresupuestos.CurrentCell.ColumnIndex == 4)
            {
                int nro = int.Parse(DGVpresupuestos.CurrentRow.Cells["Presupuesto"].Value.ToString()); ;
                FormDetallePresupuesto form = new FormDetallePresupuesto(nro);
                form.ShowDialog();
            }
            else
                return;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (DGVpresupuestos.SelectedRows != null)
            {
                List<Parametro> parametros = new List<Parametro>() { new Parametro(DGVpresupuestos.CurrentRow.Cells[0].Value)};
               if (dbHelper.EjecutarConParametros("SP_ELIMINAR_PRESUPUESTOS", parametros))
                {
                    CargarDataGrid();
                    MessageBox.Show("El presupuesto fue eliminado con éxito","BORRAR",MessageBoxButtons.OK
                       ,MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Debe seleccionar un presupuesto para borrar", "BORRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
