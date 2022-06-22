using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Diz a data do Sistema
            
        }
        private void timerHora_Tick(object sender, EventArgs e) //Serve para dizer a hora do Sistema
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // As funções abaixo servem para aceder a todos os outros formulários existentes na aplicação.
        // Os try e catch servem para evitar algum erro que interrompa a aplicação de forma inesperada. 

        private void toolStripButtonClientes_Click(object sender, EventArgs e) // Formulário Clientes
        {
            try
            {
                Form_GestaoClientes fclientes = new Form_GestaoClientes();
                fclientes.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possivel entrar no formulário dos Clientes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void toolStripButtonRestaurantes_Click(object sender, EventArgs e) // Formulário Restaurantes
        {
            try
            {
                Form_GestaoGlobalRestaurantes frestaurantes = new Form_GestaoGlobalRestaurantes();
                frestaurantes.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possivel entrar no formulário dos Restaurantes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void toolStripButtonPedidos_Click(object sender, EventArgs e) // Formulário Pedidos
        {
            try
            {
                Form_Pedidos fpedidos = new Form_Pedidos();
                fpedidos.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possivel entrar no formulário dos Pedidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void toolStripButtonMenu_Click(object sender, EventArgs e) // Formulário Menu
        {
            try
            {
                Form_Menu fmenu = new Form_Menu();
                fmenu.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possivel entrar no formulário do Menu!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Formulário Individual de Restaurante
        {
            try
            {
                Form_IndividualRestaurante findividualrest = new Form_IndividualRestaurante();
                findividualrest.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possivel entrar no formulário Individual de Restaurante!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


    }
}
