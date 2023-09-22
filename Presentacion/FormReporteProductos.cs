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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();
        }

        private void FormReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSProductos.SP_CONSULTAR_PRODUCTOS1' Puede moverla o quitarla según sea necesario.
            /*this.sP_CONSULTAR_PRODUCTOS1TableAdapter.Fill(this.dSProductos.SP_CONSULTAR_PRODUCTOS1);

            this.reportViewer1.RefreshReport();
        */}

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt=new DBHelper().Consultar("SP_CONSULTAR_PRODUCTOS");
            this.sPCONSULTARPRODUCTOS1BindingSource.DataSource = dt;
            this.reportViewer1.RefreshReport();

        }
    }
}
