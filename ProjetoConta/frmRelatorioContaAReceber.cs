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
    public partial class frmRelatorioContaAReceber : Form
    {
        public frmRelatorioContaAReceber()
        {
            InitializeComponent();
        }

        private void FrmRelatorioContaAReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_contaAReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contaAReceberTableAdapter.Fill(this.bdContaDataSet.tb_contaAReceber);

            this.reportViewer1.RefreshReport();
        }
    }
}
