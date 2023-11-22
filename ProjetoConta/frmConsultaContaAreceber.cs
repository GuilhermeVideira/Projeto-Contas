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
    public partial class frmConsultaContaAreceber : Form
    {

        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }
        public frmConsultaContaAreceber()
        {
            InitializeComponent();
        }

        private void Tb_contaAReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contaAReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdContaDataSet);

        }

        private void FillNomeToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmConsultaContaAreceber_Load(object sender, EventArgs e)
        {
            this.tb_contaAReceberTableAdapter.Fill(this.bdContaDataSet.tb_contaAReceber);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_contaAReceberDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_contaAReceberDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void Tb_contaAReceberDataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_contaAReceberDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_contaAReceberTableAdapter.Fill(this.bdContaDataSet.tb_contaAReceber);
            }
            else
            {
                this.tb_contaAReceberTableAdapter.FillByValor(this.bdContaDataSet.tb_contaAReceber, Decimal.Parse(txtNome.Text));
            }
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Azure;
            ((TextBox)sender).ForeColor = Color.Black;
        }
    }
}
