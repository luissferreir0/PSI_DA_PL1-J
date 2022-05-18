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
            this.button_menus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_menus
            // 
            this.button_menus.Location = new System.Drawing.Point(302, 167);
            this.button_menus.Name = "button_menus";
            this.button_menus.Size = new System.Drawing.Size(148, 91);
            this.button_menus.TabIndex = 0;
            this.button_menus.Text = "Abrir Menus";
            this.button_menus.UseVisualStyleBackColor = true;
            this.button_menus.Click += new System.EventHandler(this.button_menus_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_menus);
            this.Name = "Form_Principal";
            this.Text = "Form Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_menus;
    }
}

