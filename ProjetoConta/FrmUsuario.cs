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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void  habilitaexibicao()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
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
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
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


        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bdContaDataSet.tb_usuario);
            DesabilitaEdicao();  
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
            tb_usuarioBindingSource.AddNew();       
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            habilitaexibicao();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tb_usuarioBindingSource.CancelEdit();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(bdContaDataSet.tb_usuario);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.RemoveCurrent();
            tb_usuarioTableAdapter.Update(bdContaDataSet.tb_usuario);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmConsultaUsuario fpu = new frmConsultaUsuario();
            fpu.ShowDialog();

            cod = fpu.getCodigo();

            if (cod > 0)
            {
                reg = tb_usuarioBindingSource.Find("cd_usuario", cod);
                if (reg >= 0)
                {
                    tb_usuarioBindingSource.Position = reg;
                }
            }

        }

        private void Nm_usuarioTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Azure;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void Nm_usuarioTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "-- Ficha de cadastro do Usúario --" + (char)10 + (char)10;
            
            strDados = strDados + "Código: " + cd_usuarioTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + nm_usuarioTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Nível: " + sg_nivelTextBox.Text + (char)10 + (char)10;
            strDados = strDados + "Login: " + nm_loginTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Blue, 50, 50);

            objImpressao.DrawLine( new Pen(Brushes.Black, 1), 50, 72, 780, 72);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
