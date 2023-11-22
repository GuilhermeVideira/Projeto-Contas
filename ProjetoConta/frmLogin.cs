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
    public partial class frmLogin : Form
    {
        static public string nivel = "A";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bdContaDataSet.tb_usuario);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tb_usuarioTableAdapter.FillLogin(bdContaDataSet.tb_usuario, txtLogin.Text, txtSenha.Text);
            if (tb_usuarioBindingSource.Count > 0 || (txtLogin.Text == "Adm" && txtSenha.Text == "123"))
            {
                if(txtLogin.Text !="Adm")
                {
                    nivel = sg_nivelTextBox.Text;
                }
         
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
                
            }
            else 
            {
                MessageBox.Show(" -- Dados Inseridos Inválidos! -- ");
                txtLogin.Focus();
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
