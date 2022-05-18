namespace RestGest
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.dB_RestGestDataSet = new RestGest.DB_RestGestDataSet();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.RestauranteSetTableAdapter();
            this.tableAdapterManager = new RestGest.DB_RestGestDataSetTableAdapters.TableAdapterManager();
            this.restauranteSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.restauranteSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.restauranteSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Rest = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingNavigator)).BeginInit();
            this.restauranteSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetDataGridView)).BeginInit();
            this.groupBox_Rest.SuspendLayout();
            this.SuspendLayout();
            // 
            // dB_RestGestDataSet
            // 
            this.dB_RestGestDataSet.DataSetName = "DB_RestGestDataSet";
            this.dB_RestGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.dB_RestGestDataSet;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuPedidoTableAdapter = null;
            this.tableAdapterManager.ItemMenuRestauranteTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = this.restauranteSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestGest.DB_RestGestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restauranteSetBindingNavigator
            // 
            this.restauranteSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.restauranteSetBindingNavigator.BindingSource = this.restauranteSetBindingSource;
            this.restauranteSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.restauranteSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.restauranteSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.restauranteSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.restauranteSetBindingNavigatorSaveItem});
            this.restauranteSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.restauranteSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.restauranteSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.restauranteSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.restauranteSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.restauranteSetBindingNavigator.Name = "restauranteSetBindingNavigator";
            this.restauranteSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.restauranteSetBindingNavigator.Size = new System.Drawing.Size(1353, 27);
            this.restauranteSetBindingNavigator.TabIndex = 0;
            this.restauranteSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // restauranteSetBindingNavigatorSaveItem
            // 
            this.restauranteSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restauranteSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("restauranteSetBindingNavigatorSaveItem.Image")));
            this.restauranteSetBindingNavigatorSaveItem.Name = "restauranteSetBindingNavigatorSaveItem";
            this.restauranteSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.restauranteSetBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.restauranteSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.restauranteSetBindingNavigatorSaveItem_Click);
            // 
            // restauranteSetDataGridView
            // 
            this.restauranteSetDataGridView.AutoGenerateColumns = false;
            this.restauranteSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restauranteSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.restauranteSetDataGridView.DataSource = this.restauranteSetBindingSource;
            this.restauranteSetDataGridView.Location = new System.Drawing.Point(6, 21);
            this.restauranteSetDataGridView.Name = "restauranteSetDataGridView";
            this.restauranteSetDataGridView.RowHeadersWidth = 51;
            this.restauranteSetDataGridView.RowTemplate.Height = 24;
            this.restauranteSetDataGridView.Size = new System.Drawing.Size(412, 614);
            this.restauranteSetDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // groupBox_Rest
            // 
            this.groupBox_Rest.Controls.Add(this.restauranteSetDataGridView);
            this.groupBox_Rest.Location = new System.Drawing.Point(12, 31);
            this.groupBox_Rest.Name = "groupBox_Rest";
            this.groupBox_Rest.Size = new System.Drawing.Size(424, 641);
            this.groupBox_Rest.TabIndex = 2;
            this.groupBox_Rest.TabStop = false;
            this.groupBox_Rest.Text = "SelectRest (Temp)";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 684);
            this.Controls.Add(this.groupBox_Rest);
            this.Controls.Add(this.restauranteSetBindingNavigator);
            this.Name = "Form_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingNavigator)).EndInit();
            this.restauranteSetBindingNavigator.ResumeLayout(false);
            this.restauranteSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetDataGridView)).EndInit();
            this.groupBox_Rest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_RestGestDataSet dB_RestGestDataSet;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private DB_RestGestDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private DB_RestGestDataSetTableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private DB_RestGestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator restauranteSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton restauranteSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView restauranteSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox_Rest;
    }
}