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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void habilitaexibicao()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgMaskedTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgMaskedTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
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

        private void Tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();

        }

        private void Tb_clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.bdContaDataSet.tb_cliente);
            DesabilitaEdicao();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
            tb_clienteBindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tb_clienteBindingSource.EndEdit();
            tb_clienteTableAdapter.Update(bdContaDataSet.tb_cliente);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MoveNext();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.RemoveCurrent();
            tb_clienteTableAdapter.Update(bdContaDataSet.tb_cliente);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tb_clienteBindingSource.CancelEdit();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmConsultaCliente fpu = new frmConsultaCliente();
            fpu.ShowDialog();

            cod = fpu.getCodigo();

            if (cod > 0)
            {
                reg = tb_clienteBindingSource.Find("cd_cliente", cod);
                if (reg >= 0)
                {
                    tb_clienteBindingSource.Position = reg;
                }
            }

        }

        private void Cd_clienteTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Azure;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void Cd_clienteTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private bool ValidaCpf(string cpf)
        {
            int d1, d2, dig;
            bool resp = false;

            // Primeiro verificador 

            dig = int.Parse(cpf.Substring(10, 1)) * 2;
            dig = dig + int.Parse(cpf.Substring(9, 1)) * 3;
            dig = dig + int.Parse(cpf.Substring(8, 1)) * 4;
            dig = dig + int.Parse(cpf.Substring(6, 1)) * 5;
            dig = dig + int.Parse(cpf.Substring(5, 1)) * 6;
            dig = dig + int.Parse(cpf.Substring(4, 1)) * 7;
            dig = dig + int.Parse(cpf.Substring(2, 1)) * 8;
            dig = dig + int.Parse(cpf.Substring(1, 1)) * 9;
            dig = dig + int.Parse(cpf.Substring(0, 1)) * 10;

            dig = dig % 11;
            d1 = dig < 2 ? 0 : 11 - dig;

            // Segundo verificador 

            dig = int.Parse(cpf.Substring(12, 1)) * 2;
            dig = dig + int.Parse(cpf.Substring(10, 1)) * 3;
            dig = dig + int.Parse(cpf.Substring(9, 1)) * 4;
            dig = dig + int.Parse(cpf.Substring(8, 1)) * 5;
            dig = dig + int.Parse(cpf.Substring(6, 1)) * 6;
            dig = dig + int.Parse(cpf.Substring(5, 1)) * 7;
            dig = dig + int.Parse(cpf.Substring(4, 1)) * 8;
            dig = dig + int.Parse(cpf.Substring(2, 1)) * 9;
            dig = dig + int.Parse(cpf.Substring(1, 1)) * 10;
            dig = dig + int.Parse(cpf.Substring(0, 1)) * 11;

            dig = dig % 11;
            d2 = dig < 2 ? 0 : 11 - dig;

            if (d1 == int.Parse(cpf.Substring(12, 1)) && d2 == int.Parse(cpf.Substring(13, 1)))
            resp = true;
            return resp;
        }

        private void Cd_cpfMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidaCpf(cd_cpfMaskedTextBox.Text))
            {
                MessageBox.Show("CPF Inválido!!");
                cd_cpfMaskedTextBox.Focus();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "-- Ficha de Cadastro do Cliente --" + (char)10 + (char)10;

            strDados = strDados + "Código: " + cd_clienteTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nm_clienteTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Endereço: " + nm_enderecoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Número da residência: " + cd_numeroTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Bairro: " + nm_bairroTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Cidade: " + nm_cidadeTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Sigla do estado: " + sg_estadoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CEP: " + cd_cepMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Telefone: " + ds_telefoneTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CPF: " + cd_cpfMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "RG: " + cd_rgMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Email: " + ds_emailTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, 50, 50);

            objImpressao.DrawLine(new Pen(Brushes.Black, 1), 50, 72, 780, 72);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
