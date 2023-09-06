using Carpinteria1w2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria1w2
{/*MAL EL NOMBRE DE ESTE FORM
  * CONSULTAR PRODUCTOS = NUEVO PRESUPUESTO ||*/
    public partial class FormConsultarProductos : Form
    {
        DBHelper dbHelper = new DBHelper();
        Presupuesto presu;
        List<Producto> productos=new List<Producto>();
        

        public FormConsultarProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtcantidad.Text) || !int.TryParse(txtcantidad.Text, out _))
                MessageBox.Show("Debe ingresar una cantidad", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        //BOTON AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (comboBoxprod.SelectedIndex != -1)
                { 
                    foreach(DataGridViewRow row in DGVdetalles.Rows)
                    {
                        if (row.Cells["ColProducto"].Value.ToString().Equals(comboBoxprod.Text))
                        {
                            MessageBox.Show("Este producto ya está presupuestado", "Control");
                            return;
                        }
                    }
                    DataRowView item = (DataRowView)comboBoxprod.SelectedItem;
                    int prod=(int)item.Row.ItemArray[0];
                    string nom = item.Row.ItemArray[1].ToString();
                    double precio = Convert.ToDouble(item.Row.ItemArray[2]);
                    Producto p = new Producto(prod,nom,precio);
                    int cant = Convert.ToInt32(txtcantidad.Text);
                    DetallePresupuesto d = new DetallePresupuesto(p,cant);
                    presu.Detalles.Add(d);
                    DGVdetalles.Rows.Add(new object[]
                    {
                        d.Producto.ProductoNro,
                        d.Producto.Nombre,
                        d.Producto.Precio,
                        d.Cantidad,
                        "Quitar"
                    });
                    CalcularTotales();
                    
                }
                else
                    MessageBox.Show("Debe seleccionar un producto para agregar un detalle!","Agregar",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void QuitarDetalle()
        {

        }
        private void CalcularTotales()
        {
            txtboxSubtotal.Text = presu.CalcularTotal().ToString();
            double desc=presu.CalcularTotal()*Convert.ToDouble(txtboxdescuento.Text)/100;
            txtboxTotal.Text=(presu.CalcularTotal()-desc).ToString();
        }

        private void FormConsultarProductos_Load(object sender, EventArgs e)
        {
            presu=new Presupuesto();
            txtboxFecha.Text = DateTime.Today.ToShortDateString();
            txtboxcliente.Text = "Consumidor Final";
            txtboxdescuento.Text = "0";
            txtcantidad.Text = "1";
            lblpresupuestonro.Text = lblpresupuestonro.Text + " " + dbHelper.ProximoPresupuesto(); 
            CargarProductos();
        }

        

        private void CargarProductos()
        {
            DataTable dt = new DataTable();
            dt=dbHelper.Consultar("SP_CONSULTAR_PRODUCTOS");
            comboBoxprod.DataSource = dt;
            comboBoxprod.ValueMember = dt.Columns[0].ColumnName;
            comboBoxprod.DisplayMember = dt.Columns[1].ColumnName;
            comboBoxprod.DropDownStyle = ComboBoxStyle.DropDownList;
        } 

        private void DGVdetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validar
            if (string.IsNullOrEmpty(txtboxcliente.Text))
            {
                MessageBox.Show("ingrese un cliente");
                return;
            }
            if (DGVdetalles.Rows.Count==0)
            {
                MessageBox.Show("ingrese un detalle");
                return;
            }
            GrabarPresupuesto();
            //grabar
        }

        private void GrabarPresupuesto()
        {
            presu.Fecha = Convert.ToDateTime(txtboxFecha.Text);
            presu.Cliente = txtboxcliente.Text;
            presu.Descuento = Convert.ToDouble(txtboxdescuento.Text);
            int afectadas=dbHelper.Insertar("SP_INSERTAR_MAESTRO",presu);
            if (afectadas > 0)
            {
                MessageBox.Show("El presupuesto se grabó con éxito");
                this.Dispose();
            }
        }
    }
}
