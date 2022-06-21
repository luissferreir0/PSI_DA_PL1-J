namespace RestGest
{
    partial class Form_GestaoGlobalRestaurantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxFichaCliente = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAlterarPais = new System.Windows.Forms.TextBox();
            this.textBoxAlterarCodPostal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAlterarRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAlterarCidade = new System.Windows.Forms.TextBox();
            this.textBoxAlterarNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAlterarDados = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxMetodosPagamentos = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAterarPagamentos = new System.Windows.Forms.Button();
            this.comboBoxMetodoPagamentoAtivo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonMetodosPagamento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMetodoPagamento = new System.Windows.Forms.TextBox();
            this.buttonRemoverMetodoPagamento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCategoriasMenu = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategoriaEstado = new System.Windows.Forms.ComboBox();
            this.buttonAlterarCategoria = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCriarCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMenuCategoria = new System.Windows.Forms.TextBox();
            this.buttonRemoverCategoria = new System.Windows.Forms.Button();
            this.groupBoxListaClientes = new System.Windows.Forms.GroupBox();
            this.listBoxGlobalRestaurantes = new System.Windows.Forms.ListBox();
            this.groupBoxNovoCliente = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.buttonCriarRestaurantes = new System.Windows.Forms.Button();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeRestauranteNovo = new System.Windows.Forms.TextBox();
            this.buttonRemoverRestaurante = new System.Windows.Forms.Button();
            this.dB_RestGestDataSet = new RestGest.DB_RestGestDataSet();
            this.dBRestGestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.EstadoSetTableAdapter();
            this.fKEstadoPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoSetTableAdapter = new RestGest.DB_RestGestDataSetTableAdapters.PedidoSetTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBoxFichaCliente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxListaClientes.SuspendLayout();
            this.groupBoxNovoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRestGestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEstadoPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxFichaCliente);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBoxListaClientes);
            this.groupBox1.Location = new System.Drawing.Point(5, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1252, 686);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurantes";
            // 
            // groupBoxFichaCliente
            // 
            this.groupBoxFichaCliente.Controls.Add(this.label12);
            this.groupBoxFichaCliente.Controls.Add(this.textBoxAlterarPais);
            this.groupBoxFichaCliente.Controls.Add(this.textBoxAlterarCodPostal);
            this.groupBoxFichaCliente.Controls.Add(this.label11);
            this.groupBoxFichaCliente.Controls.Add(this.textBoxAlterarRua);
            this.groupBoxFichaCliente.Controls.Add(this.label10);
            this.groupBoxFichaCliente.Controls.Add(this.textBoxAlterarCidade);
            this.groupBoxFichaCliente.Controls.Add(this.textBoxAlterarNome);
            this.groupBoxFichaCliente.Controls.Add(this.label8);
            this.groupBoxFichaCliente.Controls.Add(this.label7);
            this.groupBoxFichaCliente.Controls.Add(this.buttonAlterarDados);
            this.groupBoxFichaCliente.Location = new System.Drawing.Point(411, 21);
            this.groupBoxFichaCliente.Name = "groupBoxFichaCliente";
            this.groupBoxFichaCliente.Size = new System.Drawing.Size(835, 112);
            this.groupBoxFichaCliente.TabIndex = 8;
            this.groupBoxFichaCliente.TabStop = false;
            this.groupBoxFichaCliente.Text = "Ficha do Restaurante Selecionado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(558, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Pais";
            // 
            // textBoxAlterarPais
            // 
            this.textBoxAlterarPais.Location = new System.Drawing.Point(608, 33);
            this.textBoxAlterarPais.Multiline = true;
            this.textBoxAlterarPais.Name = "textBoxAlterarPais";
            this.textBoxAlterarPais.Size = new System.Drawing.Size(196, 22);
            this.textBoxAlterarPais.TabIndex = 19;
            // 
            // textBoxAlterarCodPostal
            // 
            this.textBoxAlterarCodPostal.Location = new System.Drawing.Point(379, 82);
            this.textBoxAlterarCodPostal.Multiline = true;
            this.textBoxAlterarCodPostal.Name = "textBoxAlterarCodPostal";
            this.textBoxAlterarCodPostal.Size = new System.Drawing.Size(196, 22);
            this.textBoxAlterarCodPostal.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Codigo-Postal";
            // 
            // textBoxAlterarRua
            // 
            this.textBoxAlterarRua.Location = new System.Drawing.Point(328, 33);
            this.textBoxAlterarRua.Multiline = true;
            this.textBoxAlterarRua.Name = "textBoxAlterarRua";
            this.textBoxAlterarRua.Size = new System.Drawing.Size(196, 22);
            this.textBoxAlterarRua.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Rua";
            // 
            // textBoxAlterarCidade
            // 
            this.textBoxAlterarCidade.Location = new System.Drawing.Point(65, 85);
            this.textBoxAlterarCidade.Multiline = true;
            this.textBoxAlterarCidade.Name = "textBoxAlterarCidade";
            this.textBoxAlterarCidade.Size = new System.Drawing.Size(196, 22);
            this.textBoxAlterarCidade.TabIndex = 14;
            // 
            // textBoxAlterarNome
            // 
            this.textBoxAlterarNome.Location = new System.Drawing.Point(65, 33);
            this.textBoxAlterarNome.Multiline = true;
            this.textBoxAlterarNome.Name = "textBoxAlterarNome";
            this.textBoxAlterarNome.Size = new System.Drawing.Size(196, 22);
            this.textBoxAlterarNome.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome";
            // 
            // buttonAlterarDados
            // 
            this.buttonAlterarDados.Location = new System.Drawing.Point(710, 77);
            this.buttonAlterarDados.Name = "buttonAlterarDados";
            this.buttonAlterarDados.Size = new System.Drawing.Size(119, 29);
            this.buttonAlterarDados.TabIndex = 6;
            this.buttonAlterarDados.Text = "Alterar Dados";
            this.buttonAlterarDados.UseVisualStyleBackColor = true;
            this.buttonAlterarDados.Click += new System.EventHandler(this.buttonAlterarDados_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxMetodosPagamentos);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.buttonRemoverMetodoPagamento);
            this.groupBox4.Location = new System.Drawing.Point(830, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 514);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Metodos de Pagamento ";
            // 
            // listBoxMetodosPagamentos
            // 
            this.listBoxMetodosPagamentos.FormattingEnabled = true;
            this.listBoxMetodosPagamentos.ItemHeight = 16;
            this.listBoxMetodosPagamentos.Location = new System.Drawing.Point(29, 68);
            this.listBoxMetodosPagamentos.Name = "listBoxMetodosPagamentos";
            this.listBoxMetodosPagamentos.Size = new System.Drawing.Size(311, 260);
            this.listBoxMetodosPagamentos.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAterarPagamentos);
            this.groupBox5.Controls.Add(this.comboBoxMetodoPagamentoAtivo);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.buttonMetodosPagamento);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBoxMetodoPagamento);
            this.groupBox5.Location = new System.Drawing.Point(18, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 157);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Novo Metodo de Pagamento";
            // 
            // buttonAterarPagamentos
            // 
            this.buttonAterarPagamentos.Location = new System.Drawing.Point(98, 125);
            this.buttonAterarPagamentos.Name = "buttonAterarPagamentos";
            this.buttonAterarPagamentos.Size = new System.Drawing.Size(82, 26);
            this.buttonAterarPagamentos.TabIndex = 11;
            this.buttonAterarPagamentos.Text = "Alterar";
            this.buttonAterarPagamentos.UseVisualStyleBackColor = true;
            this.buttonAterarPagamentos.Click += new System.EventHandler(this.buttonAterarPagamentos_Click);
            // 
            // comboBoxMetodoPagamentoAtivo
            // 
            this.comboBoxMetodoPagamentoAtivo.FormattingEnabled = true;
            this.comboBoxMetodoPagamentoAtivo.Location = new System.Drawing.Point(76, 78);
            this.comboBoxMetodoPagamentoAtivo.Name = "comboBoxMetodoPagamentoAtivo";
            this.comboBoxMetodoPagamentoAtivo.Size = new System.Drawing.Size(196, 24);
            this.comboBoxMetodoPagamentoAtivo.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Ativo";
            // 
            // buttonMetodosPagamento
            // 
            this.buttonMetodosPagamento.Location = new System.Drawing.Point(216, 125);
            this.buttonMetodosPagamento.Name = "buttonMetodosPagamento";
            this.buttonMetodosPagamento.Size = new System.Drawing.Size(82, 26);
            this.buttonMetodosPagamento.TabIndex = 5;
            this.buttonMetodosPagamento.Text = "Criar";
            this.buttonMetodosPagamento.UseVisualStyleBackColor = true;
            this.buttonMetodosPagamento.Click += new System.EventHandler(this.buttonMetodosPagamento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Metodo:";
            // 
            // textBoxMetodoPagamento
            // 
            this.textBoxMetodoPagamento.Location = new System.Drawing.Point(76, 34);
            this.textBoxMetodoPagamento.Multiline = true;
            this.textBoxMetodoPagamento.Name = "textBoxMetodoPagamento";
            this.textBoxMetodoPagamento.Size = new System.Drawing.Size(196, 22);
            this.textBoxMetodoPagamento.TabIndex = 5;
            // 
            // buttonRemoverMetodoPagamento
            // 
            this.buttonRemoverMetodoPagamento.Location = new System.Drawing.Point(116, 33);
            this.buttonRemoverMetodoPagamento.Name = "buttonRemoverMetodoPagamento";
            this.buttonRemoverMetodoPagamento.Size = new System.Drawing.Size(147, 29);
            this.buttonRemoverMetodoPagamento.TabIndex = 3;
            this.buttonRemoverMetodoPagamento.Text = "Remover";
            this.buttonRemoverMetodoPagamento.UseVisualStyleBackColor = true;
            this.buttonRemoverMetodoPagamento.Click += new System.EventHandler(this.buttonRemoverMetodoPagamento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxCategoriasMenu);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonRemoverCategoria);
            this.groupBox2.Location = new System.Drawing.Point(411, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 520);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias de Menu";
            // 
            // listBoxCategoriasMenu
            // 
            this.listBoxCategoriasMenu.FormattingEnabled = true;
            this.listBoxCategoriasMenu.ItemHeight = 16;
            this.listBoxCategoriasMenu.Location = new System.Drawing.Point(29, 68);
            this.listBoxCategoriasMenu.Name = "listBoxCategoriasMenu";
            this.listBoxCategoriasMenu.Size = new System.Drawing.Size(311, 260);
            this.listBoxCategoriasMenu.TabIndex = 6;
            this.listBoxCategoriasMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxCategoriasMenu_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxCategoriaEstado);
            this.groupBox3.Controls.Add(this.buttonAlterarCategoria);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.buttonCriarCategoria);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxMenuCategoria);
            this.groupBox3.Location = new System.Drawing.Point(18, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 163);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar Categoria Menu";
            // 
            // comboBoxCategoriaEstado
            // 
            this.comboBoxCategoriaEstado.FormattingEnabled = true;
            this.comboBoxCategoriaEstado.Location = new System.Drawing.Point(68, 83);
            this.comboBoxCategoriaEstado.Name = "comboBoxCategoriaEstado";
            this.comboBoxCategoriaEstado.Size = new System.Drawing.Size(196, 24);
            this.comboBoxCategoriaEstado.TabIndex = 9;
            // 
            // buttonAlterarCategoria
            // 
            this.buttonAlterarCategoria.Location = new System.Drawing.Point(81, 131);
            this.buttonAlterarCategoria.Name = "buttonAlterarCategoria";
            this.buttonAlterarCategoria.Size = new System.Drawing.Size(82, 26);
            this.buttonAlterarCategoria.TabIndex = 8;
            this.buttonAlterarCategoria.Text = "Alterar";
            this.buttonAlterarCategoria.UseVisualStyleBackColor = true;
            this.buttonAlterarCategoria.Click += new System.EventHandler(this.buttonAlterarCategoria_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Ativo";
            // 
            // buttonCriarCategoria
            // 
            this.buttonCriarCategoria.Location = new System.Drawing.Point(203, 131);
            this.buttonCriarCategoria.Name = "buttonCriarCategoria";
            this.buttonCriarCategoria.Size = new System.Drawing.Size(82, 26);
            this.buttonCriarCategoria.TabIndex = 5;
            this.buttonCriarCategoria.Text = "Criar";
            this.buttonCriarCategoria.UseVisualStyleBackColor = true;
            this.buttonCriarCategoria.Click += new System.EventHandler(this.buttonCriarCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Menu";
            // 
            // textBoxMenuCategoria
            // 
            this.textBoxMenuCategoria.Location = new System.Drawing.Point(68, 34);
            this.textBoxMenuCategoria.Multiline = true;
            this.textBoxMenuCategoria.Name = "textBoxMenuCategoria";
            this.textBoxMenuCategoria.Size = new System.Drawing.Size(196, 22);
            this.textBoxMenuCategoria.TabIndex = 5;
            // 
            // buttonRemoverCategoria
            // 
            this.buttonRemoverCategoria.Location = new System.Drawing.Point(111, 33);
            this.buttonRemoverCategoria.Name = "buttonRemoverCategoria";
            this.buttonRemoverCategoria.Size = new System.Drawing.Size(147, 29);
            this.buttonRemoverCategoria.TabIndex = 3;
            this.buttonRemoverCategoria.Text = "Remover";
            this.buttonRemoverCategoria.UseVisualStyleBackColor = true;
            this.buttonRemoverCategoria.Click += new System.EventHandler(this.buttonRemoverCategoria_Click);
            // 
            // groupBoxListaClientes
            // 
            this.groupBoxListaClientes.Controls.Add(this.listBoxGlobalRestaurantes);
            this.groupBoxListaClientes.Controls.Add(this.groupBoxNovoCliente);
            this.groupBoxListaClientes.Controls.Add(this.buttonRemoverRestaurante);
            this.groupBoxListaClientes.Location = new System.Drawing.Point(6, 54);
            this.groupBoxListaClientes.Name = "groupBoxListaClientes";
            this.groupBoxListaClientes.Size = new System.Drawing.Size(385, 626);
            this.groupBoxListaClientes.TabIndex = 5;
            this.groupBoxListaClientes.TabStop = false;
            this.groupBoxListaClientes.Text = "Lista Global de Restaurantes";
            // 
            // listBoxGlobalRestaurantes
            // 
            this.listBoxGlobalRestaurantes.FormattingEnabled = true;
            this.listBoxGlobalRestaurantes.ItemHeight = 16;
            this.listBoxGlobalRestaurantes.Location = new System.Drawing.Point(29, 85);
            this.listBoxGlobalRestaurantes.Name = "listBoxGlobalRestaurantes";
            this.listBoxGlobalRestaurantes.Size = new System.Drawing.Size(311, 260);
            this.listBoxGlobalRestaurantes.TabIndex = 6;
            this.listBoxGlobalRestaurantes.SelectedIndexChanged += new System.EventHandler(this.listBoxGlobalRestaurantes_SelectedIndexChanged);
            // 
            // groupBoxNovoCliente
            // 
            this.groupBoxNovoCliente.Controls.Add(this.label9);
            this.groupBoxNovoCliente.Controls.Add(this.label5);
            this.groupBoxNovoCliente.Controls.Add(this.label3);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxPais);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxCodPostal);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxRua);
            this.groupBoxNovoCliente.Controls.Add(this.buttonCriarRestaurantes);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxCidade);
            this.groupBoxNovoCliente.Controls.Add(this.label2);
            this.groupBoxNovoCliente.Controls.Add(this.label1);
            this.groupBoxNovoCliente.Controls.Add(this.textBoxNomeRestauranteNovo);
            this.groupBoxNovoCliente.Location = new System.Drawing.Point(18, 368);
            this.groupBoxNovoCliente.Name = "groupBoxNovoCliente";
            this.groupBoxNovoCliente.Size = new System.Drawing.Size(343, 252);
            this.groupBoxNovoCliente.TabIndex = 5;
            this.groupBoxNovoCliente.TabStop = false;
            this.groupBoxNovoCliente.Text = "Criar Novo Restaurante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo-Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rua";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(126, 194);
            this.textBoxPais.Multiline = true;
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(196, 22);
            this.textBoxPais.TabIndex = 9;
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(126, 155);
            this.textBoxCodPostal.Multiline = true;
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(196, 22);
            this.textBoxCodPostal.TabIndex = 8;
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(126, 111);
            this.textBoxRua.Multiline = true;
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(196, 22);
            this.textBoxRua.TabIndex = 7;
            // 
            // buttonCriarRestaurantes
            // 
            this.buttonCriarRestaurantes.Location = new System.Drawing.Point(240, 220);
            this.buttonCriarRestaurantes.Name = "buttonCriarRestaurantes";
            this.buttonCriarRestaurantes.Size = new System.Drawing.Size(82, 26);
            this.buttonCriarRestaurantes.TabIndex = 5;
            this.buttonCriarRestaurantes.Text = "Criar";
            this.buttonCriarRestaurantes.UseVisualStyleBackColor = true;
            this.buttonCriarRestaurantes.Click += new System.EventHandler(this.buttonCriarRestaurantes_Click);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(126, 67);
            this.textBoxCidade.Multiline = true;
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(196, 22);
            this.textBoxCidade.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxNomeRestauranteNovo
            // 
            this.textBoxNomeRestauranteNovo.Location = new System.Drawing.Point(126, 34);
            this.textBoxNomeRestauranteNovo.Multiline = true;
            this.textBoxNomeRestauranteNovo.Name = "textBoxNomeRestauranteNovo";
            this.textBoxNomeRestauranteNovo.Size = new System.Drawing.Size(196, 22);
            this.textBoxNomeRestauranteNovo.TabIndex = 5;
            // 
            // buttonRemoverRestaurante
            // 
            this.buttonRemoverRestaurante.Location = new System.Drawing.Point(109, 39);
            this.buttonRemoverRestaurante.Name = "buttonRemoverRestaurante";
            this.buttonRemoverRestaurante.Size = new System.Drawing.Size(147, 29);
            this.buttonRemoverRestaurante.TabIndex = 3;
            this.buttonRemoverRestaurante.Text = "Remover";
            this.buttonRemoverRestaurante.UseVisualStyleBackColor = true;
            this.buttonRemoverRestaurante.Click += new System.EventHandler(this.buttonRemoverRestaurante_Click);
            // 
            // dB_RestGestDataSet
            // 
            this.dB_RestGestDataSet.DataSetName = "DB_RestGestDataSet";
            this.dB_RestGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBRestGestDataSetBindingSource
            // 
            this.dBRestGestDataSetBindingSource.DataSource = this.dB_RestGestDataSet;
            this.dBRestGestDataSetBindingSource.Position = 0;
            // 
            // estadoSetBindingSource
            // 
            this.estadoSetBindingSource.DataMember = "EstadoSet";
            this.estadoSetBindingSource.DataSource = this.dBRestGestDataSetBindingSource;
            // 
            // estadoSetTableAdapter
            // 
            this.estadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // fKEstadoPedidoBindingSource
            // 
            this.fKEstadoPedidoBindingSource.DataMember = "FK_EstadoPedido";
            this.fKEstadoPedidoBindingSource.DataSource = this.estadoSetBindingSource;
            // 
            // pedidoSetTableAdapter
            // 
            this.pedidoSetTableAdapter.ClearBeforeFill = true;
            // 
            // Form_GestaoGlobalRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 711);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_GestaoGlobalRestaurantes";
            this.Text = "Gestão Global de Restaurantes";
            this.Load += new System.EventHandler(this.Form_GestaoGlobalRestaurantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxFichaCliente.ResumeLayout(false);
            this.groupBoxFichaCliente.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxListaClientes.ResumeLayout(false);
            this.groupBoxNovoCliente.ResumeLayout(false);
            this.groupBoxNovoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRestGestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEstadoPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxFichaCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAlterarDados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxMetodosPagamentos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonMetodosPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMetodoPagamento;
        private System.Windows.Forms.Button buttonRemoverMetodoPagamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCategoriasMenu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCriarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMenuCategoria;
        private System.Windows.Forms.Button buttonRemoverCategoria;
        private System.Windows.Forms.GroupBox groupBoxListaClientes;
        private System.Windows.Forms.ListBox listBoxGlobalRestaurantes;
        private System.Windows.Forms.GroupBox groupBoxNovoCliente;
        private System.Windows.Forms.Button buttonCriarRestaurantes;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeRestauranteNovo;
        private System.Windows.Forms.Button buttonRemoverRestaurante;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAlterarPais;
        private System.Windows.Forms.TextBox textBoxAlterarCodPostal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAlterarRua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAlterarCidade;
        private System.Windows.Forms.TextBox textBoxAlterarNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAlterarCategoria;
        private System.Windows.Forms.BindingSource dBRestGestDataSetBindingSource;
        private DB_RestGestDataSet dB_RestGestDataSet;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private DB_RestGestDataSetTableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
        private System.Windows.Forms.BindingSource fKEstadoPedidoBindingSource;
        private DB_RestGestDataSetTableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCategoriaEstado;
        private System.Windows.Forms.Button buttonAterarPagamentos;
        private System.Windows.Forms.ComboBox comboBoxMetodoPagamentoAtivo;
        private System.Windows.Forms.Label label14;
    }
}