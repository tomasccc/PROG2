namespace Carpinteria1w2
{
    partial class Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVpresupuestos = new System.Windows.Forms.DataGridView();
            this.Presupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechahasta = new System.Windows.Forms.DateTimePicker();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.dtpFechadesde = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpresupuestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVpresupuestos
            // 
            this.DGVpresupuestos.AllowUserToAddRows = false;
            this.DGVpresupuestos.AllowUserToDeleteRows = false;
            this.DGVpresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Presupuesto,
            this.Fecha,
            this.Cliente,
            this.Total,
            this.Acciones});
            this.DGVpresupuestos.Location = new System.Drawing.Point(12, 153);
            this.DGVpresupuestos.Name = "DGVpresupuestos";
            this.DGVpresupuestos.ReadOnly = true;
            this.DGVpresupuestos.Size = new System.Drawing.Size(543, 225);
            this.DGVpresupuestos.TabIndex = 0;
            this.DGVpresupuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVpresupuestos_CellContentClick);
            // 
            // Presupuesto
            // 
            this.Presupuesto.HeaderText = "Presupuesto";
            this.Presupuesto.Name = "Presupuesto";
            this.Presupuesto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Acciones.Text = "Ver Detalles";
            this.Acciones.UseColumnTextForButtonValue = true;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(401, 66);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(136, 30);
            this.btnconsultar.TabIndex = 1;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechahasta);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.dtpFechadesde);
            this.groupBox1.Controls.Add(this.btnconsultar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Desde";
            // 
            // dtpFechahasta
            // 
            this.dtpFechahasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechahasta.Location = new System.Drawing.Point(285, 37);
            this.dtpFechahasta.Name = "dtpFechahasta";
            this.dtpFechahasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechahasta.TabIndex = 4;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(93, 76);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(287, 20);
            this.txtcliente.TabIndex = 3;
            // 
            // dtpFechadesde
            // 
            this.dtpFechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechadesde.Location = new System.Drawing.Point(93, 37);
            this.dtpFechadesde.Name = "dtpFechadesde";
            this.dtpFechadesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechadesde.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(348, 398);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 26);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(459, 398);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(96, 26);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 441);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVpresupuestos);
            this.Name = "Consultar";
            this.Text = "FormConsultarPresupuesto";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVpresupuestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVpresupuestos;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechahasta;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.DateTimePicker dtpFechadesde;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}