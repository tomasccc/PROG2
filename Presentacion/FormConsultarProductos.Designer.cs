namespace Carpinteria1w2
{
    partial class FormConsultarProductos
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
            this.txtboxFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxdescuento = new System.Windows.Forms.TextBox();
            this.comboBoxprod = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DGVdetalles = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtboxSubtotal = new System.Windows.Forms.TextBox();
            this.txtboxTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpresupuestonro = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxFecha
            // 
            this.txtboxFecha.Location = new System.Drawing.Point(121, 72);
            this.txtboxFecha.Name = "txtboxFecha";
            this.txtboxFecha.Size = new System.Drawing.Size(140, 20);
            this.txtboxFecha.TabIndex = 0;
            this.txtboxFecha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtboxcliente
            // 
            this.txtboxcliente.Location = new System.Drawing.Point(121, 103);
            this.txtboxcliente.Name = "txtboxcliente";
            this.txtboxcliente.Size = new System.Drawing.Size(140, 20);
            this.txtboxcliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "% Descuento";
            // 
            // txtboxdescuento
            // 
            this.txtboxdescuento.Location = new System.Drawing.Point(121, 134);
            this.txtboxdescuento.Name = "txtboxdescuento";
            this.txtboxdescuento.Size = new System.Drawing.Size(140, 20);
            this.txtboxdescuento.TabIndex = 4;
            // 
            // comboBoxprod
            // 
            this.comboBoxprod.FormattingEnabled = true;
            this.comboBoxprod.Location = new System.Drawing.Point(30, 171);
            this.comboBoxprod.Name = "comboBoxprod";
            this.comboBoxprod.Size = new System.Drawing.Size(231, 21);
            this.comboBoxprod.TabIndex = 6;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(267, 172);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(123, 20);
            this.txtcantidad.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(396, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVdetalles
            // 
            this.DGVdetalles.AllowUserToAddRows = false;
            this.DGVdetalles.AllowUserToDeleteRows = false;
            this.DGVdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.ColProducto,
            this.Colprecio,
            this.Colcantidad,
            this.ColAcciones});
            this.DGVdetalles.Location = new System.Drawing.Point(30, 198);
            this.DGVdetalles.Name = "DGVdetalles";
            this.DGVdetalles.ReadOnly = true;
            this.DGVdetalles.Size = new System.Drawing.Size(441, 163);
            this.DGVdetalles.TabIndex = 9;
            this.DGVdetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdetalles_CellContentClick);
            // 
            // Col
            // 
            this.Col.HeaderText = "ID";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.Visible = false;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            // 
            // Colprecio
            // 
            this.Colprecio.HeaderText = "Precio";
            this.Colprecio.Name = "Colprecio";
            this.Colprecio.ReadOnly = true;
            // 
            // Colcantidad
            // 
            this.Colcantidad.HeaderText = "Cantidad";
            this.Colcantidad.Name = "Colcantidad";
            this.Colcantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "Quitar";
            // 
            // txtboxSubtotal
            // 
            this.txtboxSubtotal.Enabled = false;
            this.txtboxSubtotal.Location = new System.Drawing.Point(357, 379);
            this.txtboxSubtotal.Name = "txtboxSubtotal";
            this.txtboxSubtotal.Size = new System.Drawing.Size(114, 20);
            this.txtboxSubtotal.TabIndex = 10;
            // 
            // txtboxTotal
            // 
            this.txtboxTotal.Enabled = false;
            this.txtboxTotal.Location = new System.Drawing.Point(357, 416);
            this.txtboxTotal.Name = "txtboxTotal";
            this.txtboxTotal.Size = new System.Drawing.Size(114, 20);
            this.txtboxTotal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sub total $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total $";
            // 
            // lblpresupuestonro
            // 
            this.lblpresupuestonro.AutoSize = true;
            this.lblpresupuestonro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblpresupuestonro.Location = new System.Drawing.Point(27, 29);
            this.lblpresupuestonro.Name = "lblpresupuestonro";
            this.lblpresupuestonro.Size = new System.Drawing.Size(81, 13);
            this.lblpresupuestonro.TabIndex = 14;
            this.lblpresupuestonro.Text = "Presupuesto N°";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(121, 473);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(276, 473);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 508);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblpresupuestonro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxTotal);
            this.Controls.Add(this.txtboxSubtotal);
            this.Controls.Add(this.DGVdetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.comboBoxprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxdescuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxFecha);
            this.Name = "FormConsultarProductos";
            this.Text = "text";
            this.Load += new System.EventHandler(this.FormConsultarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxdescuento;
        private System.Windows.Forms.ComboBox comboBoxprod;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView DGVdetalles;
        private System.Windows.Forms.TextBox txtboxSubtotal;
        private System.Windows.Forms.TextBox txtboxTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblpresupuestonro;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}