using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConta
{
    public partial class frmContaAPagar : Form
    {
        public frmContaAPagar()
        {
            InitializeComponent();
        }

        private void habilitaexibicao()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = true;
            cd_fornecedorTextBox.Enabled = true;
            vl_contaTextBox.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            dt_pagamento_DateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;

        }

        private void DesabilitaEdicao()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            cd_fornecedorTextBox.Enabled = false;
            vl_contaTextBox.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            dt_pagamento_DateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        private void Tb_ContaAPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ContaAPagarBindingSource.EndEdit();

        }

        private void FrmContaAPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_ContaAPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ContaAPagarTableAdapter.Fill(this.bdContaDataSet.tb_ContaAPagar);
            DesabilitaEdicao();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_ContaAPagarBindingSource.MovePrevious();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_ContaAPagarBindingSource.RemoveCurrent();
            tb_ContaAPagarTableAdapter.Update(bdContaDataSet.tb_ContaAPagar);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
            tb_ContaAPagarBindingSource.AddNew();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tb_ContaAPagarBindingSource.CancelEdit();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_ContaAPagarBindingSource.MoveNext();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tb_ContaAPagarBindingSource.EndEdit();
            tb_ContaAPagarTableAdapter.Update(bdContaDataSet.tb_ContaAPagar);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmConsultaContaapagar fpu = new frmConsultaContaapagar();
            fpu.ShowDialog();

            cod = fpu.getCodigo();

            if (cod > 0)
            {
                reg = tb_ContaAPagarBindingSource.Find("cd_conta", cod);
                if (reg >= 0)
                {
                    tb_ContaAPagarBindingSource.Position = reg;
                }
            }
        }

        private void Cd_contaTextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.White;
                ((TextBox)sender).ForeColor = Color.Black;
            }
            else
            {
                ((DateTimePicker)sender).BackColor = Color.Azure;
                ((DateTimePicker)sender).ForeColor = Color.Black;
            }

        }

        private void Cd_contaTextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox) {
                ((TextBox)sender).BackColor = Color.Azure;
                ((TextBox)sender).ForeColor = Color.Black;
            } else
            {
                ((DateTimePicker)sender).BackColor = Color.Azure;
                ((DateTimePicker)sender).ForeColor = Color.Black;
            }

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "-- Ficha Conta A Pagar --" + (char)10 + (char)10;

            strDados = strDados + "Código: " + cd_contaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Emissão: " + dt_emissaoDateTimePicker.Text + (char)10 + (char)10;
            strDados = strDados + "Código do Fornecedor: " + cd_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Valor da Conta: " + vl_contaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Vencimento: " + dt_vencimentoDateTimePicker.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Pagamento: " + dt_pagamento_DateTimePicker.Text + (char)10 + (char)10;
            strDados = strDados + "Valor Pago: " + vl_pagoTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, 50, 50);

            objImpressao.DrawLine(new Pen(Brushes.Black, 1), 50, 72, 780, 72);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }
    }
}
