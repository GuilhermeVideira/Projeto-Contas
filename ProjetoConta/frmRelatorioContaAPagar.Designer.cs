namespace ProjetoConta
{
    partial class frmRelatorioContaAPagar
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
            this.tb_ContaAPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdContaDataSet = new ProjetoConta.bdContaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_ContaAPagarTableAdapter = new ProjetoConta.bdContaDataSetTableAdapters.tb_ContaAPagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaAPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdContaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ContaAPagarBindingSource
            // 
            this.tb_ContaAPagarBindingSource.DataMember = "tb_ContaAPagar";
            this.tb_ContaAPagarBindingSource.DataSource = this.bdContaDataSet;
            // 
            // bdContaDataSet
            // 
            this.bdContaDataSet.DataSetName = "bdContaDataSet";
            this.bdContaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_ContaAPagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoConta.RelatorioContaAPagar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_ContaAPagarTableAdapter
            // 
            this.tb_ContaAPagarTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioContaAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioContaAPagar";
            this.Text = "Relatório Conta A Pagar";
            this.Load += new System.EventHandler(this.FrmRelatorioContaAPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaAPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdContaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_ContaAPagarBindingSource;
        private bdContaDataSet bdContaDataSet;
        private bdContaDataSetTableAdapters.tb_ContaAPagarTableAdapter tb_ContaAPagarTableAdapter;
    }
}