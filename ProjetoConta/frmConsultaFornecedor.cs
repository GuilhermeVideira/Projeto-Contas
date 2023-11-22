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
    public partial class frmConsultaFornecedor : Form
    {

        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }

        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void Tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdContaDataSet);

        }

        private void FrmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.bdContaDataSet.tb_fornecedor);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void Tb_fornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_fornecedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_fornecedorTableAdapter.Fill(this.bdContaDataSet.tb_fornecedor);
            }
            else
            {
                this.tb_fornecedorTableAdapter.FillByNome(this.bdContaDataSet.tb_fornecedor, "%" + txtNome.Text + "%");
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
