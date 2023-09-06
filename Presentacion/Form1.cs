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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarProductos f = new FormConsultarProductos();
            f.ShowDialog();
        }

        //boton consultar
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar f = new Consultar();
            f.ShowDialog();
        }
    }
}
