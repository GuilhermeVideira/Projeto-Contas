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
    public partial class frmConsultaUsuario : Form
    {
        private int codigo;

        public  int getCodigo()
        {
            return codigo;
        }

        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdContaDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.bdContaDataSet.tb_usuario);

        }

        private void Tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdContaDataSet);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
          
        }

        private void Tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tb_usuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_usuarioTableAdapter.Fill(this.bdContaDataSet.tb_usuario);
            }
            else
            {
                this.tb_usuarioTableAdapter.FillByNome(this.bdContaDataSet.tb_usuario, "%" + txtNome.Text + "%");
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
