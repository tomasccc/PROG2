namespace Carpinteria1w2.Presentacion
{
    partial class FormReporteProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPCONSULTARPRODUCTOS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSProductos = new Carpinteria1w2.Presentacion.Reportes.DSProductos();
            this.sP_CONSULTAR_PRODUCTOS1TableAdapter = new Carpinteria1w2.Presentacion.Reportes.DSProductosTableAdapters.SP_CONSULTAR_PRODUCTOS1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARPRODUCTOS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProductos";
            reportDataSource1.Value = this.sPCONSULTARPRODUCTOS1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carpinteria1w2.Presentacion.Reportes.objeto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sPCONSULTARPRODUCTOS1BindingSource
            // 
            this.sPCONSULTARPRODUCTOS1BindingSource.DataMember = "SP_CONSULTAR_PRODUCTOS1";
            this.sPCONSULTARPRODUCTOS1BindingSource.DataSource = this.dSProductos;
            // 
            // dSProductos
            // 
            this.dSProductos.DataSetName = "DSProductos";
            this.dSProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_CONSULTAR_PRODUCTOS1TableAdapter
            // 
            this.sP_CONSULTAR_PRODUCTOS1TableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteProductos";
            this.Text = "FormReporteProductos";
            this.Load += new System.EventHandler(this.FormReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARPRODUCTOS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DSProductos dSProductos;
        private System.Windows.Forms.BindingSource sPCONSULTARPRODUCTOS1BindingSource;
        private Reportes.DSProductosTableAdapters.SP_CONSULTAR_PRODUCTOS1TableAdapter sP_CONSULTAR_PRODUCTOS1TableAdapter;
    }
}