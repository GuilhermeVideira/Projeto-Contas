namespace ProjetoConta
{
    partial class frmContaAPagar
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
            System.Windows.Forms.Label cd_contaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaAPagar));
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label dt_pagamento_Label;
            System.Windows.Forms.Label vl_pagoLabel;
            this.label6 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.bdContaDataSet = new ProjetoConta.bdContaDataSet();
            this.tb_ContaAPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ContaAPagarTableAdapter = new ProjetoConta.bdContaDataSetTableAdapters.tb_ContaAPagarTableAdapter();
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.vl_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_pagamento_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_contaLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            dt_pagamento_Label = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdContaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaAPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cd_contaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            cd_contaLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_contaLabel.Image")));
            cd_contaLabel.Location = new System.Drawing.Point(101, 87);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(129, 20);
            cd_contaLabel.TabIndex = 53;
            cd_contaLabel.Text = "Código da conta:";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dt_emissaoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dt_emissaoLabel.Image = ((System.Drawing.Image)(resources.GetObject("dt_emissaoLabel.Image")));
            dt_emissaoLabel.Location = new System.Drawing.Point(101, 125);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(133, 20);
            dt_emissaoLabel.TabIndex = 55;
            dt_emissaoLabel.Text = "Data de emissão:";
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cd_fornecedorLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            cd_fornecedorLabel.Image = ((System.Drawing.Image)(resources.GetObject("cd_fornecedorLabel.Image")));
            cd_fornecedorLabel.Location = new System.Drawing.Point(101, 163);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(166, 20);
            cd_fornecedorLabel.TabIndex = 57;
            cd_fornecedorLabel.Text = "Código do fornecedor:";
            cd_fornecedorLabel.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            cd_fornecedorLabel.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            vl_contaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            vl_contaLabel.Image = ((System.Drawing.Image)(resources.GetObject("vl_contaLabel.Image")));
            vl_contaLabel.Location = new System.Drawing.Point(101, 201);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(116, 20);
            vl_contaLabel.TabIndex = 59;
            vl_contaLabel.Text = "Valor da conta:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dt_vencimentoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dt_vencimentoLabel.Image = ((System.Drawing.Image)(resources.GetObject("dt_vencimentoLabel.Image")));
            dt_vencimentoLabel.Location = new System.Drawing.Point(101, 239);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(155, 20);
            dt_vencimentoLabel.TabIndex = 61;
            dt_vencimentoLabel.Text = "Data de vencimento:";
            dt_vencimentoLabel.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            dt_vencimentoLabel.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // dt_pagamento_Label
            // 
            dt_pagamento_Label.AutoSize = true;
            dt_pagamento_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dt_pagamento_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dt_pagamento_Label.Image = ((System.Drawing.Image)(resources.GetObject("dt_pagamento_Label.Image")));
            dt_pagamento_Label.Location = new System.Drawing.Point(101, 277);
            dt_pagamento_Label.Name = "dt_pagamento_Label";
            dt_pagamento_Label.Size = new System.Drawing.Size(155, 20);
            dt_pagamento_Label.TabIndex = 63;
            dt_pagamento_Label.Text = "Data de pagamento:";
            dt_pagamento_Label.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            dt_pagamento_Label.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            vl_pagoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            vl_pagoLabel.Image = ((System.Drawing.Image)(resources.GetObject("vl_pagoLabel.Image")));
            vl_pagoLabel.Location = new System.Drawing.Point(101, 315);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(90, 20);
            vl_pagoLabel.TabIndex = 65;
            vl_pagoLabel.Text = "Valor pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(206, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Formulário de cadastro: Conta a pagar";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(529, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 52;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(529, 369);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 51;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(434, 397);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 50;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(434, 369);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 49;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(340, 397);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(340, 369);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 47;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(246, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(246, 369);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(100, 30);
            this.btnProximo.TabIndex = 45;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(153, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(153, 369);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 30);
            this.btnAnterior.TabIndex = 43;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // bdContaDataSet
            // 
            this.bdContaDataSet.DataSetName = "bdContaDataSet";
            this.bdContaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ContaAPagarBindingSource
            // 
            this.tb_ContaAPagarBindingSource.DataMember = "tb_ContaAPagar";
            this.tb_ContaAPagarBindingSource.DataSource = this.bdContaDataSet;
            // 
            // tb_ContaAPagarTableAdapter
            // 
            this.tb_ContaAPagarTableAdapter.ClearBeforeFill = true;
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaAPagarBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Location = new System.Drawing.Point(232, 88);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(47, 20);
            this.cd_contaTextBox.TabIndex = 54;
            this.cd_contaTextBox.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            this.cd_contaTextBox.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ContaAPagarBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(240, 125);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.dt_emissaoDateTimePicker.TabIndex = 56;
            this.dt_emissaoDateTimePicker.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            this.dt_emissaoDateTimePicker.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaAPagarBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(273, 165);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(51, 20);
            this.cd_fornecedorTextBox.TabIndex = 58;
            this.cd_fornecedorTextBox.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            this.cd_fornecedorTextBox.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // vl_contaTextBox
            // 
            this.vl_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaAPagarBindingSource, "vl_conta", true));
            this.vl_contaTextBox.Location = new System.Drawing.Point(223, 201);
            this.vl_contaTextBox.Name = "vl_contaTextBox";
            this.vl_contaTextBox.Size = new System.Drawing.Size(127, 20);
            this.vl_contaTextBox.TabIndex = 60;
            this.vl_contaTextBox.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            this.vl_contaTextBox.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ContaAPagarBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(262, 238);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.dt_vencimentoDateTimePicker.TabIndex = 62;
            this.dt_vencimentoDateTimePicker.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            this.dt_vencimentoDateTimePicker.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // dt_pagamento_DateTimePicker
            // 
            this.dt_pagamento_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ContaAPagarBindingSource, "dt_pagamento ", true));
            this.dt_pagamento_DateTimePicker.Location = new System.Drawing.Point(262, 276);
            this.dt_pagamento_DateTimePicker.Name = "dt_pagamento_DateTimePicker";
            this.dt_pagamento_DateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.dt_pagamento_DateTimePicker.TabIndex = 64;
            this.dt_pagamento_DateTimePicker.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            this.dt_pagamento_DateTimePicker.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaAPagarBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Location = new System.Drawing.Point(197, 317);
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vl_pagoTextBox.TabIndex = 66;
            this.vl_pagoTextBox.Enter += new System.EventHandler(this.Cd_contaTextBox_Enter);
            this.vl_pagoTextBox.Leave += new System.EventHandler(this.Cd_contaTextBox_Leave);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmContaAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.vl_contaTextBox);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(dt_pagamento_Label);
            this.Controls.Add(this.dt_pagamento_DateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.label6);
            this.Name = "frmContaAPagar";
            this.Text = "Cadastro conta a pagar";
            this.Load += new System.EventHandler(this.FrmContaAPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdContaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaAPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAnterior;
        private bdContaDataSet bdContaDataSet;
        private System.Windows.Forms.BindingSource tb_ContaAPagarBindingSource;
        private bdContaDataSetTableAdapters.tb_ContaAPagarTableAdapter tb_ContaAPagarTableAdapter;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox vl_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_pagamento_DateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}