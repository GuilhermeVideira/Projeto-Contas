using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ProjetoConta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            //Instanciando o Formulário
            frmSplashScreen frmSplashScreen = new frmSplashScreen();

            // Exibindo o SplashScreen 
            frmSplashScreen.Show();

            Thread.Sleep(3000);
            frmSplashScreen.Close();

        }

        private void UsúarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLogin.nivel == "A" )
            {
                FrmUsuario fu = new FrmUsuario();
                fu.ShowDialog();
            }
            else
            {
                MessageBox.Show(" -- Acesso não autorizado! -- ");
            }
       
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fu = new frmCliente();
            fu.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor fu = new frmFornecedor();
            fu.ShowDialog();
        }

        private void contaAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContaAPagar fu = new frmContaAPagar();
            fu.ShowDialog();
        }

        private void contaAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContaAReceber fu = new frmContaAReceber();
            fu.ShowDialog();
        }

        private void UsúarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario fr = new frmRelatorioUsuario();
            fr.ShowDialog();
        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente fr = new frmRelatorioCliente();
            fr.ShowDialog();
        }

        private void FornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioFornecedor fr = new frmRelatorioFornecedor();
            fr.ShowDialog();
        }

        private void ContaAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioContaAPagar fr = new frmRelatorioContaAPagar();
            fr.ShowDialog();
        }

        private void ContaAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioContaAReceber fr = new frmRelatorioContaAReceber();
            fr.ShowDialog();
        }

        private void ContaAReceberToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmRelatorioContaAReceber fr = new frmRelatorioContaAReceber();
            fr.ShowDialog();
        }
    }
}
