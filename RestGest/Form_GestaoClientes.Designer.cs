namespace RestGest
{
    partial class Form_GestaoClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonRemoverCliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContribuinte = new System.Windows.Forms.TextBox();
            this.buttonCriarCliente = new System.Windows.Forms.Button();
            this.buttonAlterarDados = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxCadeiaRestCliente = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão de Clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonRemoverCliente);
            this.groupBox2.Controls.Add(this.listBoxClientes);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 374);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista dos Clientes";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 38);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(792, 147);
            this.listBoxClientes.TabIndex = 0;
            // 
            // buttonRemoverCliente
            // 
            this.buttonRemoverCliente.Location = new System.Drawing.Point(56, 14);
            this.buttonRemoverCliente.Name = "buttonRemoverCliente";
            this.buttonRemoverCliente.Size = new System.Drawing.Size(691, 23);
            this.buttonRemoverCliente.TabIndex = 1;
            this.buttonRemoverCliente.Text = "Remover Clientes";
            this.buttonRemoverCliente.UseVisualStyleBackColor = true;
            this.buttonRemoverCliente.Click += new System.EventHandler(this.buttonRemoverCliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAlterarDados);
            this.groupBox3.Controls.Add(this.buttonCriarCliente);
            this.groupBox3.Controls.Add(this.textBoxContribuinte);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxTelemovel);
            this.groupBox3.Controls.Add(this.textBoxMorada);
            this.groupBox3.Controls.Add(this.textBoxNome);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 183);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telemóvel:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(52, 20);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(445, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(60, 45);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(437, 20);
            this.textBoxMorada.TabIndex = 4;
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(71, 72);
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(426, 20);
            this.textBoxTelemovel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NºContribuinte:";
            // 
            // textBoxContribuinte
            // 
            this.textBoxContribuinte.Location = new System.Drawing.Point(88, 100);
            this.textBoxContribuinte.Name = "textBoxContribuinte";
            this.textBoxContribuinte.Size = new System.Drawing.Size(409, 20);
            this.textBoxContribuinte.TabIndex = 7;
            // 
            // buttonCriarCliente
            // 
            this.buttonCriarCliente.Location = new System.Drawing.Point(6, 126);
            this.buttonCriarCliente.Name = "buttonCriarCliente";
            this.buttonCriarCliente.Size = new System.Drawing.Size(491, 22);
            this.buttonCriarCliente.TabIndex = 8;
            this.buttonCriarCliente.Text = "CRIAR";
            this.buttonCriarCliente.UseVisualStyleBackColor = true;
            this.buttonCriarCliente.Click += new System.EventHandler(this.buttonCriarCliente_Click);
            // 
            // buttonAlterarDados
            // 
            this.buttonAlterarDados.Location = new System.Drawing.Point(6, 155);
            this.buttonAlterarDados.Name = "buttonAlterarDados";
            this.buttonAlterarDados.Size = new System.Drawing.Size(491, 23);
            this.buttonAlterarDados.TabIndex = 9;
            this.buttonAlterarDados.Text = "ALTERAR DADOS ";
            this.buttonAlterarDados.UseVisualStyleBackColor = true;
            this.buttonAlterarDados.Click += new System.EventHandler(this.buttonAlterarDados_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxCadeiaRestCliente);
            this.groupBox4.Location = new System.Drawing.Point(518, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 183);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadeias de Restaurantes:";
            // 
            // listBoxCadeiaRestCliente
            // 
            this.listBoxCadeiaRestCliente.FormattingEnabled = true;
            this.listBoxCadeiaRestCliente.Location = new System.Drawing.Point(7, 16);
            this.listBoxCadeiaRestCliente.Name = "listBoxCadeiaRestCliente";
            this.listBoxCadeiaRestCliente.Size = new System.Drawing.Size(267, 160);
            this.listBoxCadeiaRestCliente.TabIndex = 0;
            // 
            // Form_GestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 415);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_GestaoClientes";
            this.Text = "Gestão Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonRemoverCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCriarCliente;
        private System.Windows.Forms.TextBox textBoxContribuinte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelemovel;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlterarDados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxCadeiaRestCliente;
    }
}