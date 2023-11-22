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
    public partial class frmContaAReceber : Form
    {
        public frmContaAReceber()
        {
            InitializeComponent();
        }

        private void habilitaexibicao()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = true;
            cd_clienteTextBox.Enabled = true;
            vl_contaTextBox.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            vl_contaTextBox.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
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

        private void Tb_contaAReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaAReceberBindingSource.EndEdit();

        }

        private void FrmContaAReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_contaAReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaAReceberTableAdapter.Fill(this.bdContaDataSet.tb_contaAReceber);
            DesabilitaEdicao();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
            tb_contaAReceberBindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tb_contaAReceberBindingSource.CancelEdit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tb_contaAReceberBindingSource.EndEdit();
            tb_contaAReceberTableAdapter.Update(bdContaDataSet.tb_contaAReceber);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_contaAReceberBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_contaAReceberBindingSource.MoveNext();
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_contaAReceberBindingSource.RemoveCurrent();
            tb_contaAReceberTableAdapter.Update(bdContaDataSet.tb_contaAReceber);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmConsultaContaAreceber fpu = new frmConsultaContaAreceber();
            fpu.ShowDialog();

            cod = fpu.getCodigo();

            if (cod > 0)
            {
                reg = tb_contaAReceberBindingSource.Find("cd_conta", cod);
                if (reg >= 0)
                {
                    tb_contaAReceberBindingSource.Position = reg;
                }
            }
        }

        private void Vl_pagoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_contaTextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.Azure;
                ((TextBox)sender).ForeColor = Color.Black;
            }
            else
            {
                ((DateTimePicker)sender).BackColor = Color.Azure;
                ((DateTimePicker)sender).ForeColor = Color.Black;
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

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "-- Ficha Conta A Receber --" + (char)10 + (char)10;

            strDados = strDados + "Código: " + cd_contaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Emissão: " + dt_emissaoDateTimePicker.Text + (char)10 + (char)10;
            strDados = strDados + "Código do Cliente: " + cd_clienteTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Valor da Conta: " + vl_contaTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Vencimento: " + dt_vencimentoDateTimePicker.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Pagamento: " + dt_pagamentoDateTimePicker.Text + (char)10 + (char)10;
            strDados = strDados + "Valor Pago: " + vl_pagoTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, 50, 50);

            objImpressao.DrawLine(new Pen(Brushes.Black, 1), 50, 72, 780, 72);
        }
    }
}
