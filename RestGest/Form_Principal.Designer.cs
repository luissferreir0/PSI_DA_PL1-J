namespace RestGest
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRestaurantes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMenu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClientes,
            this.toolStripButtonRestaurantes,
            this.toolStripButtonPedidos,
            this.toolStripButtonMenu,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonClientes
            // 
            this.toolStripButtonClientes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClientes.Image")));
            this.toolStripButtonClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClientes.Name = "toolStripButtonClientes";
            this.toolStripButtonClientes.Size = new System.Drawing.Size(124, 22);
            this.toolStripButtonClientes.Text = "Gestão de Clientes";
            this.toolStripButtonClientes.Click += new System.EventHandler(this.toolStripButtonClientes_Click);
            // 
            // toolStripButtonRestaurantes
            // 
            this.toolStripButtonRestaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toolStripButtonRestaurantes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRestaurantes.Image")));
            this.toolStripButtonRestaurantes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRestaurantes.Name = "toolStripButtonRestaurantes";
            this.toolStripButtonRestaurantes.Size = new System.Drawing.Size(198, 22);
            this.toolStripButtonRestaurantes.Text = "Gestão e Seleção dos Restaurantes";
            this.toolStripButtonRestaurantes.Click += new System.EventHandler(this.toolStripButtonRestaurantes_Click);
            // 
            // toolStripButtonPedidos
            // 
            this.toolStripButtonPedidos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPedidos.Image")));
            this.toolStripButtonPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPedidos.Name = "toolStripButtonPedidos";
            this.toolStripButtonPedidos.Size = new System.Drawing.Size(124, 22);
            this.toolStripButtonPedidos.Text = "Gestão de Pedidos";
            this.toolStripButtonPedidos.Click += new System.EventHandler(this.toolStripButtonPedidos_Click);
            // 
            // toolStripButtonMenu
            // 
            this.toolStripButtonMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMenu.Image")));
            this.toolStripButtonMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMenu.Name = "toolStripButtonMenu";
            this.toolStripButtonMenu.Size = new System.Drawing.Size(140, 22);
            this.toolStripButtonMenu.Text = "Menu do Restaurante";
            this.toolStripButtonMenu.Click += new System.EventHandler(this.toolStripButtonMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-Vindo ao RestGest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione o Restaurante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "labelNomeRest";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(765, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(200, 22);
            this.toolStripButton1.Text = "Gestão Individual do Restaurante";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 367);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Principal";
            this.Text = "Form Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClientes;
        private System.Windows.Forms.ToolStripButton toolStripButtonRestaurantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPedidos;
        private System.Windows.Forms.ToolStripButton toolStripButtonMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

