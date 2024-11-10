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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }
        private void tbProdutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDpooDataSet);



        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpooDataSet.TbProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutosTableAdapter.Fill(this.bDpooDataSet.TbProdutos);

        }

        private void preçoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
