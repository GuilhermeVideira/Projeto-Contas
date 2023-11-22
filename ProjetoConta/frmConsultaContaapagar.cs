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

    public partial class frmConsultaContaapagar : Form
    {
        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }

        public frmConsultaContaapagar()
        {
            InitializeComponent();
        }

        private void Tb_ContaAPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ContaAPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdContaDataSet);

        }

        private void FrmConsultaContaapagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_ContaAPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ContaAPagarTableAdapter.Fill(this.bdContaDataSet.tb_ContaAPagar);

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void Tb_fornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_ContaAPagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void Tb_ContaAPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_ContaAPagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_ContaAPagarTableAdapter.Fill(this.bdContaDataSet.tb_ContaAPagar);
            }
            else
            {
                this.tb_ContaAPagarTableAdapter.FillByNome(this.bdContaDataSet.tb_ContaAPagar, Decimal.Parse(txtNome.Text));
            }
        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Azure;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            ((TextBox)sender).ForeColor = Color.Black;
        }
    }
}

 