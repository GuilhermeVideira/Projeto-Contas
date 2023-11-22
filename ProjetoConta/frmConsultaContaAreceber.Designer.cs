namespace ProjetoConta
{
    partial class frmConsultaContaAreceber
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
            System.Windows.Forms.Label lblNome;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaContaAreceber));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.bdContaDataSet = new ProjetoConta.bdContaDataSet();
            this.tb_contaAReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contaAReceberTableAdapter = new ProjetoConta.bdContaDataSetTableAdapters.tb_contaAReceberTableAdapter();
            this.tableAdapterManager = new ProjetoConta.bdContaDataSetTableAdapters.TableAdapterManager();
            this.tb_contaAReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdContaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaAReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaAReceberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNome.ForeColor = System.Drawing.SystemColors.Highlight;
            lblNome.Image = ((System.Drawing.Image)(resources.GetObject("lblNome.Image")));
            lblNome.Location = new System.Drawing.Point(36, 81);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(55, 20);
            lblNome.TabIndex = 41;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(471, 20);
            this.txtNome.TabIndex = 43;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(172, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "Consultar Conta A Receber";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(272, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 31);
            this.btnSair.TabIndex = 45;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // bdContaDataSet
            // 
            this.bdContaDataSet.DataSetName = "bdContaDataSet";
            this.bdContaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contaAReceberBindingSource
            // 
            this.tb_contaAReceberBindingSource.DataMember = "tb_contaAReceber";
            this.tb_contaAReceberBindingSource.DataSource = this.bdContaDataSet;
            // 
            // tb_contaAReceberTableAdapter
            // 
            this.tb_contaAReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_ContaAPagarTableAdapter = null;
            this.tableAdapterManager.tb_contaAReceberTableAdapter = this.tb_contaAReceberTableAdapter;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoConta.bdContaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_contaAReceberDataGridView
            // 
            this.tb_contaAReceberDataGridView.AllowUserToAddRows = false;
            this.tb_contaAReceberDataGridView.AllowUserToDeleteRows = false;
            this.tb_contaAReceberDataGridView.AutoGenerateColumns = false;
            this.tb_contaAReceberDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tb_contaAReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_contaAReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tb_contaAReceberDataGridView.DataSource = this.tb_contaAReceberBindingSource;
            this.tb_contaAReceberDataGridView.Location = new System.Drawing.Point(30, 125);
            this.tb_contaAReceberDataGridView.Name = "tb_contaAReceberDataGridView";
            this.tb_contaAReceberDataGridView.ReadOnly = true;
            this.tb_contaAReceberDataGridView.Size = new System.Drawing.Size(566, 249);
            this.tb_contaAReceberDataGridView.TabIndex = 47;
            this.tb_contaAReceberDataGridView.DoubleClick += new System.EventHandler(this.Tb_contaAReceberDataGridView_DoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_conta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vl_conta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor da conta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dt_vencimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Vencimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // frmConsultaContaAreceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 447);
            this.ControlBox = false;
            this.Controls.Add(this.tb_contaAReceberDataGridView);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(lblNome);
            this.DoubleBuffered = true;
            this.Name = "frmConsultaContaAreceber";
            this.Text = "Consultar Conta A Receber";
            this.Load += new System.EventHandler(this.FrmConsultaContaAreceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdContaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaAReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaAReceberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSair;
        private bdContaDataSet bdContaDataSet;
        private System.Windows.Forms.BindingSource tb_contaAReceberBindingSource;
        private bdContaDataSetTableAdapters.tb_contaAReceberTableAdapter tb_contaAReceberTableAdapter;
        private bdContaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_contaAReceberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}