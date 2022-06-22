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
            System.Windows.Forms.Label metodoPLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label trabalhadorIdLabel;
            System.Windows.Forms.Label nomeEstadoLabel;
            System.Windows.Forms.Label valorTotalLabel1;
            System.Windows.Forms.Label restauranteIdLabel;
            this.dB_RestGestDataSet = new RestGest.DB_RestGestDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonApedido = new System.Windows.Forms.Button();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNpedido = new System.Windows.Forms.Button();
            this.trabalhadorIdComboBox = new System.Windows.Forms.ComboBox();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.metodoPComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.estadoIdcomboBox = new System.Windows.Forms.ComboBox();
            metodoPLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            trabalhadorIdLabel = new System.Windows.Forms.Label();
            nomeEstadoLabel = new System.Windows.Forms.Label();
            valorTotalLabel1 = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(7, 155);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(65, 16);
            clienteIdLabel.TabIndex = 6;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // trabalhadorIdLabel
            // 
            trabalhadorIdLabel.AutoSize = true;
            trabalhadorIdLabel.Location = new System.Drawing.Point(7, 185);
            trabalhadorIdLabel.Name = "trabalhadorIdLabel";
            trabalhadorIdLabel.Size = new System.Drawing.Size(99, 16);
            trabalhadorIdLabel.TabIndex = 8;
            trabalhadorIdLabel.Text = "Trabalhador Id:";
            // 
            // nomeEstadoLabel
            // 
            nomeEstadoLabel.AutoSize = true;
            nomeEstadoLabel.Location = new System.Drawing.Point(7, 127);
            nomeEstadoLabel.Name = "nomeEstadoLabel";
            nomeEstadoLabel.Size = new System.Drawing.Size(53, 16);
            nomeEstadoLabel.TabIndex = 10;
            nomeEstadoLabel.Text = "Estado:";
            // 
            // valorTotalLabel1
            // 
            valorTotalLabel1.AutoSize = true;
            valorTotalLabel1.Location = new System.Drawing.Point(7, 69);
            valorTotalLabel1.Name = "valorTotalLabel1";
            valorTotalLabel1.Size = new System.Drawing.Size(76, 16);
            valorTotalLabel1.TabIndex = 2;
            valorTotalLabel1.Text = "Valor Total:";
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Location = new System.Drawing.Point(7, 215);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(97, 16);
            restauranteIdLabel.TabIndex = 10;
            restauranteIdLabel.Text = "Restaurante Id:";
            // 
            // dB_RestGestDataSet
            // 
            this.dB_RestGestDataSet.DataSetName = "DB_RestGestDataSet";
            this.dB_RestGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 342);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonApedido
            // 
            this.buttonApedido.Location = new System.Drawing.Point(358, 146);
            this.buttonApedido.Name = "buttonApedido";
            this.buttonApedido.Size = new System.Drawing.Size(155, 55);
            this.buttonApedido.TabIndex = 14;
            this.buttonApedido.Text = "Guardar Altrações";
            this.buttonApedido.UseVisualStyleBackColor = true;
            this.buttonApedido.Click += new System.EventHandler(this.buttonApedido_Click);
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.Location = new System.Drawing.Point(89, 66);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(193, 22);
            this.valorTotalTextBox.TabIndex = 3;
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(110, 212);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(172, 24);
            this.restauranteIdComboBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estadoIdcomboBox);
            this.groupBox2.Controls.Add(this.buttonApedido);
            this.groupBox2.Controls.Add(this.buttonNpedido);
            this.groupBox2.Controls.Add(nomeEstadoLabel);
            this.groupBox2.Controls.Add(valorTotalLabel1);
            this.groupBox2.Controls.Add(trabalhadorIdLabel);
            this.groupBox2.Controls.Add(this.valorTotalTextBox);
            this.groupBox2.Controls.Add(this.trabalhadorIdComboBox);
            this.groupBox2.Controls.Add(clienteIdLabel);
            this.groupBox2.Controls.Add(this.clienteIdComboBox);
            this.groupBox2.Controls.Add(restauranteIdLabel);
            this.groupBox2.Controls.Add(this.restauranteIdComboBox);
            this.groupBox2.Controls.Add(metodoPLabel);
            this.groupBox2.Controls.Add(this.metodoPComboBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 296);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo Pedido";
            // 
            // buttonNpedido
            // 
            this.buttonNpedido.Location = new System.Drawing.Point(358, 78);
            this.buttonNpedido.Name = "buttonNpedido";
            this.buttonNpedido.Size = new System.Drawing.Size(155, 55);
            this.buttonNpedido.TabIndex = 13;
            this.buttonNpedido.Text = "Novo Pedido";
            this.buttonNpedido.UseVisualStyleBackColor = true;
            // 
            // trabalhadorIdComboBox
            // 
            this.trabalhadorIdComboBox.FormattingEnabled = true;
            this.trabalhadorIdComboBox.Location = new System.Drawing.Point(112, 182);
            this.trabalhadorIdComboBox.Name = "trabalhadorIdComboBox";
            this.trabalhadorIdComboBox.Size = new System.Drawing.Size(170, 24);
            this.trabalhadorIdComboBox.TabIndex = 9;
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(78, 152);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(204, 24);
            this.clienteIdComboBox.TabIndex = 7;
            // 
            // metodoPComboBox
            // 
            this.metodoPComboBox.FormattingEnabled = true;
            this.metodoPComboBox.Location = new System.Drawing.Point(93, 94);
            this.metodoPComboBox.Name = "metodoPComboBox";
            this.metodoPComboBox.Size = new System.Drawing.Size(189, 24);
            this.metodoPComboBox.TabIndex = 3;
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
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(563, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(627, 292);
            this.listBox1.TabIndex = 1;
            // 
            // estadoIdcomboBox
            // 
            this.estadoIdcomboBox.FormattingEnabled = true;
            this.estadoIdcomboBox.Location = new System.Drawing.Point(93, 124);
            this.estadoIdcomboBox.Name = "estadoIdcomboBox";
            this.estadoIdcomboBox.Size = new System.Drawing.Size(189, 24);
            this.estadoIdcomboBox.TabIndex = 15;
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
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_RestGestDataSet dB_RestGestDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox trabalhadorIdComboBox;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.ComboBox metodoPComboBox;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.ComboBox restauranteIdComboBox;
        private System.Windows.Forms.Button buttonApedido;
        private System.Windows.Forms.Button buttonNpedido;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox estadoIdcomboBox;
    }
}