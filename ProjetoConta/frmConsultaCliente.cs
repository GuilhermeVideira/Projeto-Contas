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
    public partial class frmConsultaCliente : Form
    {
        private int codigo;

        public int getCodigo()
        {
            return codigo;
        }

        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void Tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdContaDataSet);

        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.bdContaDataSet.tb_cliente);

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void Tb_clienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_clienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                this.tb_clienteTableAdapter.Fill(this.bdContaDataSet.tb_cliente);
            }
            else
            {
                this.tb_clienteTableAdapter.FillByNome(this.bdContaDataSet.tb_cliente, "%" + txtNome.Text + "%");
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
