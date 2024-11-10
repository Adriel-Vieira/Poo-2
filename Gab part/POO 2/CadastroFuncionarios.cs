using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_2
{
    public partial class CadastroFuncionarios : Form
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void tbFuncionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFuncionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDpooDataSet);

        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpooDataSet.TbFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFuncionariosTableAdapter.Fill(this.bDpooDataSet.TbFuncionarios);

        }
    }
}
