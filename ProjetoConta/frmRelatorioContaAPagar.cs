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
    public partial class frmRelatorioContaAPagar : Form
    {
        public frmRelatorioContaAPagar()
        {
            InitializeComponent();
        }

        private void FrmRelatorioContaAPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_ContaAPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ContaAPagarTableAdapter.Fill(this.bdContaDataSet.tb_ContaAPagar);

            this.reportViewer1.RefreshReport();
        }
    }
}
