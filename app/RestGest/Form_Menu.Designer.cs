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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label ingredientesLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            this.dB_RestGestDataSet = new RestGest.DB_RestGestDataSet();
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMenuSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.ItemMenuSetTableAdapter();
            this.tableAdapterManager = new RestGest.DB_RestGestDataSetTableAdapters.TableAdapterManager();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.fotografiaPictureBox = new System.Windows.Forms.PictureBox();
            this.ingredientesTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDitem = new System.Windows.Forms.Button();
            this.buttonAitem = new System.Windows.Forms.Button();
            this.buttonNitem = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ingredientesLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotografiaPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(83, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(57, 80);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // ingredientesLabel
            // 
            ingredientesLabel.AutoSize = true;
            ingredientesLabel.Location = new System.Drawing.Point(20, 137);
            ingredientesLabel.Name = "ingredientesLabel";
            ingredientesLabel.Size = new System.Drawing.Size(84, 16);
            ingredientesLabel.TabIndex = 7;
            ingredientesLabel.Text = "Ingredientes:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new System.Drawing.Point(57, 194);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(46, 16);
            precoLabel.TabIndex = 9;
            precoLabel.Text = "Preco:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(21, 222);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(83, 16);
            categoriaIdLabel.TabIndex = 13;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // dB_RestGestDataSet
            // 
            this.dB_RestGestDataSet.DataSetName = "DB_RestGestDataSet";
            this.dB_RestGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemMenuSetBindingSource
            // 
            this.itemMenuSetBindingSource.DataMember = "ItemMenuSet";
            this.itemMenuSetBindingSource.DataSource = this.dB_RestGestDataSet;
            // 
            // itemMenuSetTableAdapter
            // 
            this.itemMenuSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuPedidoTableAdapter = null;
            this.tableAdapterManager.ItemMenuRestauranteTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = this.itemMenuSetTableAdapter;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestGest.DB_RestGestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Id", true));
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(110, 47);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(121, 24);
            this.idComboBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(110, 77);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 22);
            this.nomeTextBox.TabIndex = 4;
            // 
            // fotografiaPictureBox
            // 
            this.fotografiaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.itemMenuSetBindingSource, "Fotografia", true));
            this.fotografiaPictureBox.Location = new System.Drawing.Point(419, 12);
            this.fotografiaPictureBox.Name = "fotografiaPictureBox";
            this.fotografiaPictureBox.Size = new System.Drawing.Size(551, 290);
            this.fotografiaPictureBox.TabIndex = 6;
            this.fotografiaPictureBox.TabStop = false;
            // 
            // ingredientesTextBox
            // 
            this.ingredientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Ingredientes", true));
            this.ingredientesTextBox.Location = new System.Drawing.Point(110, 105);
            this.ingredientesTextBox.Multiline = true;
            this.ingredientesTextBox.Name = "ingredientesTextBox";
            this.ingredientesTextBox.Size = new System.Drawing.Size(121, 80);
            this.ingredientesTextBox.TabIndex = 8;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(110, 191);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(121, 22);
            this.precoTextBox.TabIndex = 10;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.itemMenuSetBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.Location = new System.Drawing.Point(292, 21);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(103, 50);
            this.ativoCheckBox.TabIndex = 12;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(110, 219);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.categoriaIdComboBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDitem);
            this.groupBox1.Controls.Add(this.buttonAitem);
            this.groupBox1.Controls.Add(this.buttonNitem);
            this.groupBox1.Controls.Add(this.categoriaIdComboBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(categoriaIdLabel);
            this.groupBox1.Controls.Add(this.idComboBox);
            this.groupBox1.Controls.Add(this.ativoCheckBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(this.precoTextBox);
            this.groupBox1.Controls.Add(precoLabel);
            this.groupBox1.Controls.Add(this.ingredientesTextBox);
            this.groupBox1.Controls.Add(ingredientesLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 290);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Item";
            // 
            // buttonDitem
            // 
            this.buttonDitem.Location = new System.Drawing.Point(292, 180);
            this.buttonDitem.Name = "buttonDitem";
            this.buttonDitem.Size = new System.Drawing.Size(103, 52);
            this.buttonDitem.TabIndex = 17;
            this.buttonDitem.Text = "Eliminar Item";
            this.buttonDitem.UseVisualStyleBackColor = true;
            // 
            // buttonAitem
            // 
            this.buttonAitem.Location = new System.Drawing.Point(292, 122);
            this.buttonAitem.Name = "buttonAitem";
            this.buttonAitem.Size = new System.Drawing.Size(103, 52);
            this.buttonAitem.TabIndex = 16;
            this.buttonAitem.Text = "Guardar Alterações";
            this.buttonAitem.UseVisualStyleBackColor = true;
            // 
            // buttonNitem
            // 
            this.buttonNitem.Location = new System.Drawing.Point(292, 64);
            this.buttonNitem.Name = "buttonNitem";
            this.buttonNitem.Size = new System.Drawing.Size(103, 52);
            this.buttonNitem.TabIndex = 15;
            this.buttonNitem.Text = "Novo Item";
            this.buttonNitem.UseVisualStyleBackColor = true;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fotografiaPictureBox);
            this.Name = "Form_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotografiaPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DB_RestGestDataSet dB_RestGestDataSet;
        private System.Windows.Forms.BindingSource itemMenuSetBindingSource;
        private DB_RestGestDataSetTableAdapters.ItemMenuSetTableAdapter itemMenuSetTableAdapter;
        private DB_RestGestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.PictureBox fotografiaPictureBox;
        private System.Windows.Forms.TextBox ingredientesTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDitem;
        private System.Windows.Forms.Button buttonAitem;
        private System.Windows.Forms.Button buttonNitem;
    }
}