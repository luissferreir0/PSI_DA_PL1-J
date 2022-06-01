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
            System.Windows.Forms.Label NitemLabel;
            System.Windows.Forms.Label metodoPLabel;
            System.Windows.Forms.Label valorTotalLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label trabalhadorIdLabel;
            System.Windows.Forms.Label nomeEstadoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label valorTotalLabel1;
            System.Windows.Forms.Label clienteIdLabel1;
            System.Windows.Forms.Label trabalhadorIdLabel1;
            System.Windows.Forms.Label estadoIdLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label AitemLabel;
            System.Windows.Forms.Label metodoPLabel1;
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RestGestDataSet = new RestGest.DB_RestGestDataSet();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMenuSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.ItemMenuSetTableAdapter();
            this.tableAdapterManager = new RestGest.DB_RestGestDataSetTableAdapters.TableAdapterManager();
            this.metodoPagamentoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.MetodoPagamentoSetTableAdapter();
            this.pedidoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.PedidoSetTableAdapter();
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fotografiaPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metodoPComboBox1 = new System.Windows.Forms.ComboBox();
            this.AitemComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.valorTotalTextBox1 = new System.Windows.Forms.TextBox();
            this.clienteIdComboBox1 = new System.Windows.Forms.ComboBox();
            this.trabalhadorIdComboBox1 = new System.Windows.Forms.ComboBox();
            this.estadoIdComboBox = new System.Windows.Forms.ComboBox();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nomeEstadoTextBox = new System.Windows.Forms.TextBox();
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhadorIdComboBox = new System.Windows.Forms.ComboBox();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.metodoPComboBox = new System.Windows.Forms.ComboBox();
            this.NitemComboBox = new System.Windows.Forms.ComboBox();
            this.estadoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.EstadoSetTableAdapter();
            this.buttonApedido = new System.Windows.Forms.Button();
            this.buttonNpedido = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            NitemLabel = new System.Windows.Forms.Label();
            metodoPLabel = new System.Windows.Forms.Label();
            valorTotalLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            trabalhadorIdLabel = new System.Windows.Forms.Label();
            nomeEstadoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            valorTotalLabel1 = new System.Windows.Forms.Label();
            clienteIdLabel1 = new System.Windows.Forms.Label();
            trabalhadorIdLabel1 = new System.Windows.Forms.Label();
            estadoIdLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            AitemLabel = new System.Windows.Forms.Label();
            metodoPLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografiaPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NitemLabel
            // 
            NitemLabel.AutoSize = true;
            NitemLabel.Location = new System.Drawing.Point(7, 67);
            NitemLabel.Name = "NitemLabel";
            NitemLabel.Size = new System.Drawing.Size(47, 16);
            NitemLabel.TabIndex = 0;
            NitemLabel.Text = "Nome:";
            // 
            // metodoPLabel
            // 
            metodoPLabel.AutoSize = true;
            metodoPLabel.Location = new System.Drawing.Point(7, 97);
            metodoPLabel.Name = "metodoPLabel";
            metodoPLabel.Size = new System.Drawing.Size(80, 16);
            metodoPLabel.TabIndex = 2;
            metodoPLabel.Text = "Pagamento:";
            // 
            // valorTotalLabel
            // 
            valorTotalLabel.AutoSize = true;
            valorTotalLabel.Location = new System.Drawing.Point(7, 127);
            valorTotalLabel.Name = "valorTotalLabel";
            valorTotalLabel.Size = new System.Drawing.Size(76, 16);
            valorTotalLabel.TabIndex = 4;
            valorTotalLabel.Text = "Valor Total:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(7, 183);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(65, 16);
            clienteIdLabel.TabIndex = 6;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // trabalhadorIdLabel
            // 
            trabalhadorIdLabel.AutoSize = true;
            trabalhadorIdLabel.Location = new System.Drawing.Point(7, 213);
            trabalhadorIdLabel.Name = "trabalhadorIdLabel";
            trabalhadorIdLabel.Size = new System.Drawing.Size(99, 16);
            trabalhadorIdLabel.TabIndex = 8;
            trabalhadorIdLabel.Text = "Trabalhador Id:";
            // 
            // nomeEstadoLabel
            // 
            nomeEstadoLabel.AutoSize = true;
            nomeEstadoLabel.Location = new System.Drawing.Point(7, 155);
            nomeEstadoLabel.Name = "nomeEstadoLabel";
            nomeEstadoLabel.Size = new System.Drawing.Size(93, 16);
            nomeEstadoLabel.TabIndex = 10;
            nomeEstadoLabel.Text = "Nome Estado:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(6, 34);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // valorTotalLabel1
            // 
            valorTotalLabel1.AutoSize = true;
            valorTotalLabel1.Location = new System.Drawing.Point(6, 62);
            valorTotalLabel1.Name = "valorTotalLabel1";
            valorTotalLabel1.Size = new System.Drawing.Size(76, 16);
            valorTotalLabel1.TabIndex = 2;
            valorTotalLabel1.Text = "Valor Total:";
            // 
            // clienteIdLabel1
            // 
            clienteIdLabel1.AutoSize = true;
            clienteIdLabel1.Location = new System.Drawing.Point(6, 90);
            clienteIdLabel1.Name = "clienteIdLabel1";
            clienteIdLabel1.Size = new System.Drawing.Size(65, 16);
            clienteIdLabel1.TabIndex = 4;
            clienteIdLabel1.Text = "Cliente Id:";
            // 
            // trabalhadorIdLabel1
            // 
            trabalhadorIdLabel1.AutoSize = true;
            trabalhadorIdLabel1.Location = new System.Drawing.Point(6, 120);
            trabalhadorIdLabel1.Name = "trabalhadorIdLabel1";
            trabalhadorIdLabel1.Size = new System.Drawing.Size(99, 16);
            trabalhadorIdLabel1.TabIndex = 6;
            trabalhadorIdLabel1.Text = "Trabalhador Id:";
            // 
            // estadoIdLabel
            // 
            estadoIdLabel.AutoSize = true;
            estadoIdLabel.Location = new System.Drawing.Point(6, 150);
            estadoIdLabel.Name = "estadoIdLabel";
            estadoIdLabel.Size = new System.Drawing.Size(67, 16);
            estadoIdLabel.TabIndex = 8;
            estadoIdLabel.Text = "Estado Id:";
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Location = new System.Drawing.Point(6, 180);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(97, 16);
            restauranteIdLabel.TabIndex = 10;
            restauranteIdLabel.Text = "Restaurante Id:";
            // 
            // AitemLabel
            // 
            AitemLabel.AutoSize = true;
            AitemLabel.Location = new System.Drawing.Point(6, 240);
            AitemLabel.Name = "AitemLabel";
            AitemLabel.Size = new System.Drawing.Size(35, 16);
            AitemLabel.TabIndex = 12;
            AitemLabel.Text = "Item:";
            // 
            // metodoPLabel1
            // 
            metodoPLabel1.AutoSize = true;
            metodoPLabel1.Location = new System.Drawing.Point(6, 210);
            metodoPLabel1.Name = "metodoPLabel1";
            metodoPLabel1.Size = new System.Drawing.Size(80, 16);
            metodoPLabel1.TabIndex = 14;
            metodoPLabel1.Text = "Pagamento:";
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
            this.groupBox1.Controls.Add(this.fotografiaPictureBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 342);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // fotografiaPictureBox
            // 
            this.fotografiaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.itemMenuSetBindingSource, "Fotografia", true));
            this.fotografiaPictureBox.Location = new System.Drawing.Point(449, 21);
            this.fotografiaPictureBox.Name = "fotografiaPictureBox";
            this.fotografiaPictureBox.Size = new System.Drawing.Size(399, 280);
            this.fotografiaPictureBox.TabIndex = 4;
            this.fotografiaPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonApedido);
            this.groupBox3.Controls.Add(metodoPLabel1);
            this.groupBox3.Controls.Add(this.metodoPComboBox1);
            this.groupBox3.Controls.Add(AitemLabel);
            this.groupBox3.Controls.Add(this.AitemComboBox);
            this.groupBox3.Controls.Add(idLabel);
            this.groupBox3.Controls.Add(this.idTextBox);
            this.groupBox3.Controls.Add(valorTotalLabel1);
            this.groupBox3.Controls.Add(this.valorTotalTextBox1);
            this.groupBox3.Controls.Add(clienteIdLabel1);
            this.groupBox3.Controls.Add(this.clienteIdComboBox1);
            this.groupBox3.Controls.Add(trabalhadorIdLabel1);
            this.groupBox3.Controls.Add(this.trabalhadorIdComboBox1);
            this.groupBox3.Controls.Add(estadoIdLabel);
            this.groupBox3.Controls.Add(this.estadoIdComboBox);
            this.groupBox3.Controls.Add(restauranteIdLabel);
            this.groupBox3.Controls.Add(this.restauranteIdComboBox);
            this.groupBox3.Location = new System.Drawing.Point(854, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 280);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alterar Pedido";
            // 
            // metodoPComboBox1
            // 
            this.metodoPComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "MetodoP", true));
            this.metodoPComboBox1.FormattingEnabled = true;
            this.metodoPComboBox1.Location = new System.Drawing.Point(92, 207);
            this.metodoPComboBox1.Name = "metodoPComboBox1";
            this.metodoPComboBox1.Size = new System.Drawing.Size(117, 24);
            this.metodoPComboBox1.TabIndex = 15;
            // 
            // AitemComboBox
            // 
            this.AitemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Nome", true));
            this.AitemComboBox.FormattingEnabled = true;
            this.AitemComboBox.Location = new System.Drawing.Point(47, 237);
            this.AitemComboBox.Name = "AitemComboBox";
            this.AitemComboBox.Size = new System.Drawing.Size(162, 24);
            this.AitemComboBox.TabIndex = 13;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(33, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(176, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // valorTotalTextBox1
            // 
            this.valorTotalTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ValorTotal", true));
            this.valorTotalTextBox1.Location = new System.Drawing.Point(88, 59);
            this.valorTotalTextBox1.Name = "valorTotalTextBox1";
            this.valorTotalTextBox1.Size = new System.Drawing.Size(121, 22);
            this.valorTotalTextBox1.TabIndex = 3;
            // 
            // clienteIdComboBox1
            // 
            this.clienteIdComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ClienteId", true));
            this.clienteIdComboBox1.FormattingEnabled = true;
            this.clienteIdComboBox1.Location = new System.Drawing.Point(77, 87);
            this.clienteIdComboBox1.Name = "clienteIdComboBox1";
            this.clienteIdComboBox1.Size = new System.Drawing.Size(132, 24);
            this.clienteIdComboBox1.TabIndex = 5;
            // 
            // trabalhadorIdComboBox1
            // 
            this.trabalhadorIdComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "TrabalhadorId", true));
            this.trabalhadorIdComboBox1.FormattingEnabled = true;
            this.trabalhadorIdComboBox1.Location = new System.Drawing.Point(111, 117);
            this.trabalhadorIdComboBox1.Name = "trabalhadorIdComboBox1";
            this.trabalhadorIdComboBox1.Size = new System.Drawing.Size(98, 24);
            this.trabalhadorIdComboBox1.TabIndex = 7;
            // 
            // estadoIdComboBox
            // 
            this.estadoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "EstadoId", true));
            this.estadoIdComboBox.FormattingEnabled = true;
            this.estadoIdComboBox.Location = new System.Drawing.Point(79, 147);
            this.estadoIdComboBox.Name = "estadoIdComboBox";
            this.estadoIdComboBox.Size = new System.Drawing.Size(130, 24);
            this.estadoIdComboBox.TabIndex = 9;
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "RestauranteId", true));
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(109, 177);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(100, 24);
            this.restauranteIdComboBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNpedido);
            this.groupBox2.Controls.Add(nomeEstadoLabel);
            this.groupBox2.Controls.Add(this.nomeEstadoTextBox);
            this.groupBox2.Controls.Add(trabalhadorIdLabel);
            this.groupBox2.Controls.Add(this.trabalhadorIdComboBox);
            this.groupBox2.Controls.Add(clienteIdLabel);
            this.groupBox2.Controls.Add(this.clienteIdComboBox);
            this.groupBox2.Controls.Add(valorTotalLabel);
            this.groupBox2.Controls.Add(this.valorTotalTextBox);
            this.groupBox2.Controls.Add(metodoPLabel);
            this.groupBox2.Controls.Add(this.metodoPComboBox);
            this.groupBox2.Controls.Add(NitemLabel);
            this.groupBox2.Controls.Add(this.NitemComboBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 280);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo Pedido";
            // 
            // nomeEstadoTextBox
            // 
            this.nomeEstadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoSetBindingSource, "NomeEstado", true));
            this.nomeEstadoTextBox.Location = new System.Drawing.Point(106, 152);
            this.nomeEstadoTextBox.Name = "nomeEstadoTextBox";
            this.nomeEstadoTextBox.Size = new System.Drawing.Size(176, 22);
            this.nomeEstadoTextBox.TabIndex = 11;
            // 
            // estadoSetBindingSource
            // 
            this.estadoSetBindingSource.DataMember = "EstadoSet";
            this.estadoSetBindingSource.DataSource = this.dB_RestGestDataSet;
            // 
            // trabalhadorIdComboBox
            // 
            this.trabalhadorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "TrabalhadorId", true));
            this.trabalhadorIdComboBox.FormattingEnabled = true;
            this.trabalhadorIdComboBox.Location = new System.Drawing.Point(112, 210);
            this.trabalhadorIdComboBox.Name = "trabalhadorIdComboBox";
            this.trabalhadorIdComboBox.Size = new System.Drawing.Size(170, 24);
            this.trabalhadorIdComboBox.TabIndex = 9;
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ClienteId", true));
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(78, 180);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(204, 24);
            this.clienteIdComboBox.TabIndex = 7;
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ValorTotal", true));
            this.valorTotalTextBox.Location = new System.Drawing.Point(89, 124);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(193, 22);
            this.valorTotalTextBox.TabIndex = 5;
            // 
            // metodoPComboBox
            // 
            this.metodoPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "MetodoP", true));
            this.metodoPComboBox.FormattingEnabled = true;
            this.metodoPComboBox.Location = new System.Drawing.Point(93, 94);
            this.metodoPComboBox.Name = "metodoPComboBox";
            this.metodoPComboBox.Size = new System.Drawing.Size(189, 24);
            this.metodoPComboBox.TabIndex = 3;
            // 
            // NitemComboBox
            // 
            this.NitemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Nome", true));
            this.NitemComboBox.FormattingEnabled = true;
            this.NitemComboBox.Location = new System.Drawing.Point(60, 64);
            this.NitemComboBox.Name = "NitemComboBox";
            this.NitemComboBox.Size = new System.Drawing.Size(222, 24);
            this.NitemComboBox.TabIndex = 1;
            // 
            // estadoSetTableAdapter
            // 
            this.estadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // buttonApedido
            // 
            this.buttonApedido.Location = new System.Drawing.Point(215, 111);
            this.buttonApedido.Name = "buttonApedido";
            this.buttonApedido.Size = new System.Drawing.Size(155, 55);
            this.buttonApedido.TabIndex = 14;
            this.buttonApedido.Text = "Guardar Altrações";
            this.buttonApedido.UseVisualStyleBackColor = true;
            // 
            // buttonNpedido
            // 
            this.buttonNpedido.Location = new System.Drawing.Point(288, 136);
            this.buttonNpedido.Name = "buttonNpedido";
            this.buttonNpedido.Size = new System.Drawing.Size(143, 55);
            this.buttonNpedido.TabIndex = 13;
            this.buttonNpedido.Text = "Novo Pedido";
            this.buttonNpedido.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1254, 27);
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
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // Form_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 407);
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
            ((System.ComponentModel.ISupportInitialize)(this.fotografiaPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox fotografiaPictureBox;
        private System.Windows.Forms.ComboBox trabalhadorIdComboBox;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.ComboBox metodoPComboBox;
        private System.Windows.Forms.ComboBox NitemComboBox;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private DB_RestGestDataSetTableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
        private System.Windows.Forms.ComboBox metodoPComboBox1;
        private System.Windows.Forms.ComboBox AitemComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox valorTotalTextBox1;
        private System.Windows.Forms.ComboBox clienteIdComboBox1;
        private System.Windows.Forms.ComboBox trabalhadorIdComboBox1;
        private System.Windows.Forms.ComboBox estadoIdComboBox;
        private System.Windows.Forms.ComboBox restauranteIdComboBox;
        private System.Windows.Forms.TextBox nomeEstadoTextBox;
        private System.Windows.Forms.Button buttonApedido;
        private System.Windows.Forms.Button buttonNpedido;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
    }
}