namespace POO_2
{
    partial class CadastroProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nome_do_produtoLabel;
            System.Windows.Forms.Label preçoLabel;
            System.Windows.Forms.Label quantidade_em_estoqueLabel;
            System.Windows.Forms.Label código_de_barrasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
            this.bDpooDataSet = new POO_2.BDpooDataSet();
            this.tbProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutosTableAdapter = new POO_2.BDpooDataSetTableAdapters.TbProdutosTableAdapter();
            this.tableAdapterManager = new POO_2.BDpooDataSetTableAdapters.TableAdapterManager();
            this.tbProdutosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbProdutosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nome_do_produtoTextBox = new System.Windows.Forms.TextBox();
            this.preçoTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_em_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.código_de_barrasTextBox = new System.Windows.Forms.TextBox();
            this.tbProdutosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nome_do_produtoLabel = new System.Windows.Forms.Label();
            preçoLabel = new System.Windows.Forms.Label();
            quantidade_em_estoqueLabel = new System.Windows.Forms.Label();
            código_de_barrasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDpooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosBindingNavigator)).BeginInit();
            this.tbProdutosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_do_produtoLabel
            // 
            nome_do_produtoLabel.AutoSize = true;
            nome_do_produtoLabel.Location = new System.Drawing.Point(12, 34);
            nome_do_produtoLabel.Name = "nome_do_produtoLabel";
            nome_do_produtoLabel.Size = new System.Drawing.Size(92, 13);
            nome_do_produtoLabel.TabIndex = 3;
            nome_do_produtoLabel.Text = "Nome do produto:";
            // 
            // preçoLabel
            // 
            preçoLabel.AutoSize = true;
            preçoLabel.Location = new System.Drawing.Point(12, 60);
            preçoLabel.Name = "preçoLabel";
            preçoLabel.Size = new System.Drawing.Size(38, 13);
            preçoLabel.TabIndex = 5;
            preçoLabel.Text = "Preço:";
            // 
            // quantidade_em_estoqueLabel
            // 
            quantidade_em_estoqueLabel.AutoSize = true;
            quantidade_em_estoqueLabel.Location = new System.Drawing.Point(12, 86);
            quantidade_em_estoqueLabel.Name = "quantidade_em_estoqueLabel";
            quantidade_em_estoqueLabel.Size = new System.Drawing.Size(123, 13);
            quantidade_em_estoqueLabel.TabIndex = 7;
            quantidade_em_estoqueLabel.Text = "Quantidade em estoque:";
            // 
            // código_de_barrasLabel
            // 
            código_de_barrasLabel.AutoSize = true;
            código_de_barrasLabel.Location = new System.Drawing.Point(12, 112);
            código_de_barrasLabel.Name = "código_de_barrasLabel";
            código_de_barrasLabel.Size = new System.Drawing.Size(90, 13);
            código_de_barrasLabel.TabIndex = 9;
            código_de_barrasLabel.Text = "Código de barras:";
            // 
            // bDpooDataSet
            // 
            this.bDpooDataSet.DataSetName = "BDpooDataSet";
            this.bDpooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutosBindingSource
            // 
            this.tbProdutosBindingSource.DataMember = "TbProdutos";
            this.tbProdutosBindingSource.DataSource = this.bDpooDataSet;
            // 
            // tbProdutosTableAdapter
            // 
            this.tbProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TbFuncionariosTableAdapter = null;
            this.tableAdapterManager.TbProdutosTableAdapter = this.tbProdutosTableAdapter;
            this.tableAdapterManager.UpdateOrder = POO_2.BDpooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbProdutosBindingNavigator
            // 
            this.tbProdutosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbProdutosBindingNavigator.BindingSource = this.tbProdutosBindingSource;
            this.tbProdutosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbProdutosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbProdutosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbProdutosBindingNavigatorSaveItem});
            this.tbProdutosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbProdutosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbProdutosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbProdutosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbProdutosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbProdutosBindingNavigator.Name = "tbProdutosBindingNavigator";
            this.tbProdutosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbProdutosBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tbProdutosBindingNavigator.TabIndex = 0;
            this.tbProdutosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbProdutosBindingNavigatorSaveItem
            // 
            this.tbProdutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbProdutosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbProdutosBindingNavigatorSaveItem.Image")));
            this.tbProdutosBindingNavigatorSaveItem.Name = "tbProdutosBindingNavigatorSaveItem";
            this.tbProdutosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbProdutosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbProdutosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbProdutosBindingNavigatorSaveItem_Click);
            // 
            // nome_do_produtoTextBox
            // 
            this.nome_do_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutosBindingSource, "Nome do produto", true));
            this.nome_do_produtoTextBox.Location = new System.Drawing.Point(141, 31);
            this.nome_do_produtoTextBox.Name = "nome_do_produtoTextBox";
            this.nome_do_produtoTextBox.Size = new System.Drawing.Size(400, 20);
            this.nome_do_produtoTextBox.TabIndex = 4;
            // 
            // preçoTextBox
            // 
            this.preçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutosBindingSource, "Preço", true));
            this.preçoTextBox.Location = new System.Drawing.Point(141, 57);
            this.preçoTextBox.Name = "preçoTextBox";
            this.preçoTextBox.Size = new System.Drawing.Size(100, 20);
            this.preçoTextBox.TabIndex = 6;
            this.preçoTextBox.TextChanged += new System.EventHandler(this.preçoTextBox_TextChanged);
            // 
            // quantidade_em_estoqueTextBox
            // 
            this.quantidade_em_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutosBindingSource, "Quantidade em estoque", true));
            this.quantidade_em_estoqueTextBox.Location = new System.Drawing.Point(141, 83);
            this.quantidade_em_estoqueTextBox.Name = "quantidade_em_estoqueTextBox";
            this.quantidade_em_estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidade_em_estoqueTextBox.TabIndex = 8;
            // 
            // código_de_barrasTextBox
            // 
            this.código_de_barrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutosBindingSource, "Código de barras", true));
            this.código_de_barrasTextBox.Location = new System.Drawing.Point(141, 109);
            this.código_de_barrasTextBox.Name = "código_de_barrasTextBox";
            this.código_de_barrasTextBox.Size = new System.Drawing.Size(200, 20);
            this.código_de_barrasTextBox.TabIndex = 10;
            // 
            // tbProdutosDataGridView
            // 
            this.tbProdutosDataGridView.AutoGenerateColumns = false;
            this.tbProdutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProdutosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbProdutosDataGridView.DataSource = this.tbProdutosBindingSource;
            this.tbProdutosDataGridView.Location = new System.Drawing.Point(12, 135);
            this.tbProdutosDataGridView.Name = "tbProdutosDataGridView";
            this.tbProdutosDataGridView.Size = new System.Drawing.Size(776, 303);
            this.tbProdutosDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProdutos";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProdutos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome do produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantidade em estoque";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade em estoque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Código de barras";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código de barras";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbProdutosDataGridView);
            this.Controls.Add(nome_do_produtoLabel);
            this.Controls.Add(this.nome_do_produtoTextBox);
            this.Controls.Add(preçoLabel);
            this.Controls.Add(this.preçoTextBox);
            this.Controls.Add(quantidade_em_estoqueLabel);
            this.Controls.Add(this.quantidade_em_estoqueTextBox);
            this.Controls.Add(código_de_barrasLabel);
            this.Controls.Add(this.código_de_barrasTextBox);
            this.Controls.Add(this.tbProdutosBindingNavigator);
            this.Name = "CadastroProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDpooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosBindingNavigator)).EndInit();
            this.tbProdutosBindingNavigator.ResumeLayout(false);
            this.tbProdutosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDpooDataSet bDpooDataSet;
        private System.Windows.Forms.BindingSource tbProdutosBindingSource;
        private BDpooDataSetTableAdapters.TbProdutosTableAdapter tbProdutosTableAdapter;
        private BDpooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbProdutosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbProdutosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nome_do_produtoTextBox;
        private System.Windows.Forms.TextBox preçoTextBox;
        private System.Windows.Forms.TextBox quantidade_em_estoqueTextBox;
        private System.Windows.Forms.TextBox código_de_barrasTextBox;
        private System.Windows.Forms.DataGridView tbProdutosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}