namespace POO_2
{
    partial class CadastroFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionarios));
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label salárioLabel;
            this.bDpooDataSet = new POO_2.BDpooDataSet();
            this.tbFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionariosTableAdapter = new POO_2.BDpooDataSetTableAdapters.TbFuncionariosTableAdapter();
            this.tableAdapterManager = new POO_2.BDpooDataSetTableAdapters.TableAdapterManager();
            this.tbFuncionariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbFuncionariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.salárioTextBox = new System.Windows.Forms.TextBox();
            this.tbFuncionariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            salárioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDpooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingNavigator)).BeginInit();
            this.tbFuncionariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDpooDataSet
            // 
            this.bDpooDataSet.DataSetName = "BDpooDataSet";
            this.bDpooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFuncionariosBindingSource
            // 
            this.tbFuncionariosBindingSource.DataMember = "TbFuncionarios";
            this.tbFuncionariosBindingSource.DataSource = this.bDpooDataSet;
            // 
            // tbFuncionariosTableAdapter
            // 
            this.tbFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TbFuncionariosTableAdapter = this.tbFuncionariosTableAdapter;
            this.tableAdapterManager.TbProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POO_2.BDpooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbFuncionariosBindingNavigator
            // 
            this.tbFuncionariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbFuncionariosBindingNavigator.BindingSource = this.tbFuncionariosBindingSource;
            this.tbFuncionariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbFuncionariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbFuncionariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbFuncionariosBindingNavigatorSaveItem});
            this.tbFuncionariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbFuncionariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbFuncionariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbFuncionariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbFuncionariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbFuncionariosBindingNavigator.Name = "tbFuncionariosBindingNavigator";
            this.tbFuncionariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbFuncionariosBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tbFuncionariosBindingNavigator.TabIndex = 0;
            this.tbFuncionariosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tbFuncionariosBindingNavigatorSaveItem
            // 
            this.tbFuncionariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFuncionariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbFuncionariosBindingNavigatorSaveItem.Image")));
            this.tbFuncionariosBindingNavigatorSaveItem.Name = "tbFuncionariosBindingNavigatorSaveItem";
            this.tbFuncionariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tbFuncionariosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbFuncionariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbFuncionariosBindingNavigatorSaveItem_Click);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 36);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionariosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(100, 33);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(400, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Location = new System.Drawing.Point(12, 62);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(38, 13);
            cargoLabel.TabIndex = 5;
            cargoLabel.Text = "Cargo:";
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionariosBindingSource, "Cargo", true));
            this.cargoTextBox.Location = new System.Drawing.Point(100, 59);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cargoTextBox.TabIndex = 6;
            // 
            // salárioLabel
            // 
            salárioLabel.AutoSize = true;
            salárioLabel.Location = new System.Drawing.Point(12, 88);
            salárioLabel.Name = "salárioLabel";
            salárioLabel.Size = new System.Drawing.Size(42, 13);
            salárioLabel.TabIndex = 7;
            salárioLabel.Text = "Salário:";
            // 
            // salárioTextBox
            // 
            this.salárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionariosBindingSource, "Salário", true));
            this.salárioTextBox.Location = new System.Drawing.Point(100, 85);
            this.salárioTextBox.Name = "salárioTextBox";
            this.salárioTextBox.Size = new System.Drawing.Size(100, 20);
            this.salárioTextBox.TabIndex = 8;
            // 
            // tbFuncionariosDataGridView
            // 
            this.tbFuncionariosDataGridView.AutoGenerateColumns = false;
            this.tbFuncionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFuncionariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tbFuncionariosDataGridView.DataSource = this.tbFuncionariosBindingSource;
            this.tbFuncionariosDataGridView.Location = new System.Drawing.Point(12, 111);
            this.tbFuncionariosDataGridView.Name = "tbFuncionariosDataGridView";
            this.tbFuncionariosDataGridView.Size = new System.Drawing.Size(776, 327);
            this.tbFuncionariosDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdFuncionarios";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdFuncionarios";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salário";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // CadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFuncionariosDataGridView);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(salárioLabel);
            this.Controls.Add(this.salárioTextBox);
            this.Controls.Add(this.tbFuncionariosBindingNavigator);
            this.Name = "CadastroFuncionarios";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.CadastroFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDpooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingNavigator)).EndInit();
            this.tbFuncionariosBindingNavigator.ResumeLayout(false);
            this.tbFuncionariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDpooDataSet bDpooDataSet;
        private System.Windows.Forms.BindingSource tbFuncionariosBindingSource;
        private BDpooDataSetTableAdapters.TbFuncionariosTableAdapter tbFuncionariosTableAdapter;
        private BDpooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbFuncionariosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbFuncionariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.TextBox salárioTextBox;
        private System.Windows.Forms.DataGridView tbFuncionariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}