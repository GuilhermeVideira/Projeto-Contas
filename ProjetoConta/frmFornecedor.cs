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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void habilitaexibicao()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            cd_ieMaskedTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
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
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            cd_ieMaskedTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
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

        private void Tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();

        }

        private void Tb_fornecedorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bdContaDataSet.tb_fornecedor);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
            tb_fornecedorBindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tb_fornecedorBindingSource.CancelEdit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tb_fornecedorBindingSource.EndEdit();
            tb_fornecedorTableAdapter.Update(bdContaDataSet.tb_fornecedor);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.RemoveCurrent();
            tb_fornecedorTableAdapter.Update(bdContaDataSet.tb_fornecedor);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmConsultaFornecedor fpu = new frmConsultaFornecedor();
            fpu.ShowDialog();

            cod = fpu.getCodigo();

            if (cod > 0)
            {
                reg = tb_fornecedorBindingSource.Find("cd_fornecedor", cod);
                if (reg >= 0)
                {
                    tb_fornecedorBindingSource.Position = reg;
                }
            }
        }

        private void Cd_fornecedorTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void Cd_fornecedorTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Azure;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void Cd_cnpjLabel_Click(object sender, EventArgs e)
        {

        }
        private void Cd_ieMaskedTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void Cd_cnpjMaskedTextBox_Leave(object sender, EventArgs e)
        {
            double dig1 = 0, dig2 = 0;

            //Primeiro Verificador
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 5;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 6;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 7;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 8;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 9;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 5;

            dig1 = dig1 % 11;
            dig1 = dig1 < 2 ? 0 : 11 - dig1;

            //Segundo Verificador
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(16, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 6;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 7;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 8;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 9;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 6;

            dig2 = dig2 % 11;
            dig2 = dig2 < 2 ? 0 : 11 - dig2;

            if (cd_cnpjMaskedTextBox.Text.Substring(16, 1) != dig1.ToString() || cd_cnpjMaskedTextBox.Text.Substring(17, 1) != dig2.ToString())
            {
                MessageBox.Show("CNPJ Inválido!!!");
                cd_cnpjMaskedTextBox.Focus();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "-- Ficha de Cadastro do Fornecedor --" + (char)10 + (char)10;

            strDados = strDados + "Código: " + cd_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nm_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Endereço: " + nm_enderecoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Número da residência: " + cd_numeroTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Bairro: " + nm_bairroTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Cidade: " + nm_cidadeTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Sigla do estado: " + sg_estadoTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CEP: " + cd_cepMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Telefone: " + ds_telefoneTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Código IE: " + cd_ieMaskedTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "CNPJ: " + cd_cnpjMaskedTextBox.Text + (char)10 + (char)10;
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