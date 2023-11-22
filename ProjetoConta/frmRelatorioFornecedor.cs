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
    public partial class frmRelatorioFornecedor : Form
    {
        public frmRelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void FrmRelatorioFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bdContaDataSet.tb_fornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
