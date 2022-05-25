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
        }

        private void toolStripButtonClientes_Click(object sender, EventArgs e) // Formulário Clientes
        {
            Form_GestaoClientes fclientes = new Form_GestaoClientes();
            fclientes.Show();
        }

        private void toolStripButtonRestaurantes_Click(object sender, EventArgs e) // Formulário Restaurantes
        {
            Form_GestaoGlobalRestaurantes frestaurantes = new Form_GestaoGlobalRestaurantes();
            frestaurantes.Show();
        }

        private void toolStripButtonPedidos_Click(object sender, EventArgs e) // Formulário Pedidos
        {
            Form_Pedidos fpedidos = new Form_Pedidos();
            fpedidos.Show();
        }

        private void toolStripButtonMenu_Click(object sender, EventArgs e) // Formulário Menu
        {
            Form_Menu fmenu = new Form_Menu();
            fmenu.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_IndividualRestaurante findividualrest = new Form_IndividualRestaurante();
            findividualrest.Show();
        }
    }
}
