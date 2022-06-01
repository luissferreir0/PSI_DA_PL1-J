namespace RestGest
{
    partial class Form_Pedidos
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
            System.Windows.Forms.Label metodoPLabel;
            System.Windows.Forms.Label valorTotalLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label trabalhadorIdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label estadoIdLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label nomeLabel;
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RestGestDataSet = new RestGest.DB_RestGestDataSet();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMenuSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.ItemMenuSetTableAdapter();
            this.tableAdapterManager = new RestGest.DB_RestGestDataSetTableAdapters.TableAdapterManager();
            this.metodoPagamentoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.MetodoPagamentoSetTableAdapter();
            this.pedidoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.PedidoSetTableAdapter();
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonApedido = new System.Windows.Forms.Button();
            this.buttonNpedido = new System.Windows.Forms.Button();
            this.fotografiaPictureBox = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.trabalhadorIdComboBox = new System.Windows.Forms.ComboBox();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.metodoPComboBox = new System.Windows.Forms.ComboBox();
            this.estadoIdComboBox = new System.Windows.Forms.ComboBox();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.EstadoSetTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeListBox = new System.Windows.Forms.ListBox();
            metodoPLabel = new System.Windows.Forms.Label();
            valorTotalLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            trabalhadorIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            estadoIdLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografiaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metodoPLabel
            // 
            metodoPLabel.AutoSize = true;
            metodoPLabel.Location = new System.Drawing.Point(13, 173);
            metodoPLabel.Name = "metodoPLabel";
            metodoPLabel.Size = new System.Drawing.Size(80, 16);
            metodoPLabel.TabIndex = 2;
            metodoPLabel.Text = "Pagamento:";
            // 
            // valorTotalLabel
            // 
            valorTotalLabel.AutoSize = true;
            valorTotalLabel.Location = new System.Drawing.Point(13, 203);
            valorTotalLabel.Name = "valorTotalLabel";
            valorTotalLabel.Size = new System.Drawing.Size(76, 16);
            valorTotalLabel.TabIndex = 4;
            valorTotalLabel.Text = "Valor Total:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(13, 52);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(67, 16);
            clienteIdLabel.TabIndex = 6;
            clienteIdLabel.Text = "ID Cliente:";
            // 
            // trabalhadorIdLabel
            // 
            trabalhadorIdLabel.AutoSize = true;
            trabalhadorIdLabel.Location = new System.Drawing.Point(13, 82);
            trabalhadorIdLabel.Name = "trabalhadorIdLabel";
            trabalhadorIdLabel.Size = new System.Drawing.Size(101, 16);
            trabalhadorIdLabel.TabIndex = 8;
            trabalhadorIdLabel.Text = "ID Trabalhador:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(13, 24);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(70, 16);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID Pedido:";
            // 
            // estadoIdLabel
            // 
            estadoIdLabel.AutoSize = true;
            estadoIdLabel.Location = new System.Drawing.Point(13, 112);
            estadoIdLabel.Name = "estadoIdLabel";
            estadoIdLabel.Size = new System.Drawing.Size(67, 16);
            estadoIdLabel.TabIndex = 8;
            estadoIdLabel.Text = "Estado Id:";
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Location = new System.Drawing.Point(13, 142);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(97, 16);
            restauranteIdLabel.TabIndex = 10;
            restauranteIdLabel.Text = "Restaurante Id:";
            // 
            // itemMenuSetBindingSource
            // 
            this.itemMenuSetBindingSource.DataMember = "ItemMenuSet";
            this.itemMenuSetBindingSource.DataSource = this.dB_RestGestDataSet;
            // 
            // dB_RestGestDataSet
            // 
            this.dB_RestGestDataSet.DataSetName = "DB_RestGestDataSet";
            this.dB_RestGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.dB_RestGestDataSet;
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
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = this.metodoPagamentoSetTableAdapter;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = this.pedidoSetTableAdapter;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestGest.DB_RestGestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // metodoPagamentoSetTableAdapter
            // 
            this.metodoPagamentoSetTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoSetTableAdapter
            // 
            this.pedidoSetTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoSetBindingSource
            // 
            this.pedidoSetBindingSource.DataMember = "PedidoSet";
            this.pedidoSetBindingSource.DataSource = this.dB_RestGestDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeListBox);
            this.groupBox1.Controls.Add(this.buttonApedido);
            this.groupBox1.Controls.Add(this.buttonNpedido);
            this.groupBox1.Controls.Add(this.fotografiaPictureBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(trabalhadorIdLabel);
            this.groupBox1.Controls.Add(this.trabalhadorIdComboBox);
            this.groupBox1.Controls.Add(clienteIdLabel);
            this.groupBox1.Controls.Add(this.clienteIdComboBox);
            this.groupBox1.Controls.Add(estadoIdLabel);
            this.groupBox1.Controls.Add(this.metodoPComboBox);
            this.groupBox1.Controls.Add(this.estadoIdComboBox);
            this.groupBox1.Controls.Add(valorTotalLabel);
            this.groupBox1.Controls.Add(restauranteIdLabel);
            this.groupBox1.Controls.Add(metodoPLabel);
            this.groupBox1.Controls.Add(this.restauranteIdComboBox);
            this.groupBox1.Controls.Add(this.valorTotalTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 510);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonApedido
            // 
            this.buttonApedido.Location = new System.Drawing.Point(564, 21);
            this.buttonApedido.Name = "buttonApedido";
            this.buttonApedido.Size = new System.Drawing.Size(146, 54);
            this.buttonApedido.TabIndex = 14;
            this.buttonApedido.Text = "Guardar Altrações";
            this.buttonApedido.UseVisualStyleBackColor = true;
            // 
            // buttonNpedido
            // 
            this.buttonNpedido.Location = new System.Drawing.Point(345, 21);
            this.buttonNpedido.Name = "buttonNpedido";
            this.buttonNpedido.Size = new System.Drawing.Size(145, 54);
            this.buttonNpedido.TabIndex = 13;
            this.buttonNpedido.Text = "Novo Pedido";
            this.buttonNpedido.UseVisualStyleBackColor = true;
            // 
            // fotografiaPictureBox
            // 
            this.fotografiaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.itemMenuSetBindingSource, "Fotografia", true));
            this.fotografiaPictureBox.Location = new System.Drawing.Point(345, 99);
            this.fotografiaPictureBox.Name = "fotografiaPictureBox";
            this.fotografiaPictureBox.Size = new System.Drawing.Size(365, 405);
            this.fotografiaPictureBox.TabIndex = 4;
            this.fotografiaPictureBox.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(135, 18);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(170, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // trabalhadorIdComboBox
            // 
            this.trabalhadorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "TrabalhadorId", true));
            this.trabalhadorIdComboBox.FormattingEnabled = true;
            this.trabalhadorIdComboBox.Location = new System.Drawing.Point(135, 79);
            this.trabalhadorIdComboBox.Name = "trabalhadorIdComboBox";
            this.trabalhadorIdComboBox.Size = new System.Drawing.Size(170, 24);
            this.trabalhadorIdComboBox.TabIndex = 9;
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ClienteId", true));
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(135, 49);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(170, 24);
            this.clienteIdComboBox.TabIndex = 7;
            // 
            // metodoPComboBox
            // 
            this.metodoPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "MetodoP", true));
            this.metodoPComboBox.FormattingEnabled = true;
            this.metodoPComboBox.Location = new System.Drawing.Point(135, 170);
            this.metodoPComboBox.Name = "metodoPComboBox";
            this.metodoPComboBox.Size = new System.Drawing.Size(170, 24);
            this.metodoPComboBox.TabIndex = 3;
            // 
            // estadoIdComboBox
            // 
            this.estadoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "EstadoId", true));
            this.estadoIdComboBox.FormattingEnabled = true;
            this.estadoIdComboBox.Location = new System.Drawing.Point(135, 109);
            this.estadoIdComboBox.Name = "estadoIdComboBox";
            this.estadoIdComboBox.Size = new System.Drawing.Size(170, 24);
            this.estadoIdComboBox.TabIndex = 9;
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "RestauranteId", true));
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(135, 139);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(170, 24);
            this.restauranteIdComboBox.TabIndex = 11;
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ValorTotal", true));
            this.valorTotalTextBox.Location = new System.Drawing.Point(135, 200);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(170, 22);
            this.valorTotalTextBox.TabIndex = 5;
            // 
            // estadoSetBindingSource
            // 
            this.estadoSetBindingSource.DataMember = "EstadoSet";
            this.estadoSetBindingSource.DataSource = this.dB_RestGestDataSet;
            // 
            // estadoSetTableAdapter
            // 
            this.estadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::RestGest.Properties.Resources.newCliente;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(119, 24);
            this.toolStripButton1.Text = "Novo Cliente";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::RestGest.Properties.Resources.exportar;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(99, 24);
            this.toolStripDropDownButton1.Text = "Exportar";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(13, 228);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 19;
            nomeLabel.Text = "Nome:";
            // 
            // nomeListBox
            // 
            this.nomeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemMenuSetBindingSource, "Nome", true));
            this.nomeListBox.FormattingEnabled = true;
            this.nomeListBox.ItemHeight = 16;
            this.nomeListBox.Location = new System.Drawing.Point(135, 228);
            this.nomeListBox.Name = "nomeListBox";
            this.nomeListBox.Size = new System.Drawing.Size(170, 276);
            this.nomeListBox.TabIndex = 20;
            // 
            // Form_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 552);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Form_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografiaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_RestGestDataSet dB_RestGestDataSet;
        private System.Windows.Forms.BindingSource itemMenuSetBindingSource;
        private DB_RestGestDataSetTableAdapters.ItemMenuSetTableAdapter itemMenuSetTableAdapter;
        private DB_RestGestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_RestGestDataSetTableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter;
        private System.Windows.Forms.BindingSource metodoPagamentoSetBindingSource;
        private DB_RestGestDataSetTableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private System.Windows.Forms.BindingSource pedidoSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox fotografiaPictureBox;
        private System.Windows.Forms.ComboBox trabalhadorIdComboBox;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.ComboBox metodoPComboBox;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private DB_RestGestDataSetTableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox estadoIdComboBox;
        private System.Windows.Forms.ComboBox restauranteIdComboBox;
        private System.Windows.Forms.Button buttonApedido;
        private System.Windows.Forms.Button buttonNpedido;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ListBox nomeListBox;
    }
}