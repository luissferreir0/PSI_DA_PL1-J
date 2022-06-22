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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRestaurantes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(200, 22);
            this.toolStripButton1.Text = "Gestão Individual do Restaurante";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-Vindo ao RestGest";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(148, 231);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(82, 21);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "labelData";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(584, 231);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(83, 21);
            this.labelHora.TabIndex = 5;
            this.labelHora.Text = "labelHora";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 367);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelData);
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
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timerHora;
    }
}

