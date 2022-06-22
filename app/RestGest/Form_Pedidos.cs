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
    public partial class Form_Pedidos : Form
    {
        public static RestGestContainer RestGest;

        public Form_Pedidos()
        {
            InitializeComponent();
        }

        private void Form_Pedidos_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void LerDados()
        {
            listBox1.DataSource
                = RestGest.PedidoSet.ToList();

            clienteIdComboBox.DataSource
                = RestGest.PessoaSet.ToList();

            trabalhadorIdComboBox.DataSource
                = RestGest.PessoaSet.ToList();

            restauranteIdComboBox.DataSource
                = RestGest.PessoaSet.ToList();

            metodoPComboBox.DataSource
                = RestGest.MetodoPagamentoSet.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_GestaoClientes fclientes = new Form_GestaoClientes();
            fclientes.Show();
        }

        private void Form_Pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            RestGest.Dispose();
        }

        private void buttonNpedido_Click(object sender, EventArgs e)
        {
            try
             {
                 Pedido pedido = new Pedido();

                 pedido.ValorTotal = (long)Convert.ToDouble(valorTotalTextBox.Text);
                 pedido.ClienteId = clienteIdComboBox.SelectedIndex + 1;
                 pedido.TrabalhadorId = trabalhadorIdComboBox.SelectedIndex + 1;
                 pedido.EstadoId = estadoIdcomboBox.SelectedIndex + 1;
                 pedido.RestauranteId = restauranteIdComboBox.SelectedIndex + 1;

                 RestGest.PedidoSet.Add(pedido);

                 if (string.IsNullOrEmpty(valorTotalTextBox.Text))
                 {
                     return;
                 }
                 RestGest.PedidoSet.Add(pedido);

                 RestGest.SaveChanges();
                 LerDados();
             }
             catch
             {
                 MessageBox.Show("É necessário preencher todos os dados!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
        }

        private void buttonApedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido =
                    (Pedido)listBox1.SelectedItem;
                if (pedido == null)
                {
                    return;
                }

                var pedidoDb = RestGest
                    .PedidoSet.Find(pedido.Id);
                pedidoDb.ValorTotal = (long)Convert.ToDouble(valorTotalTextBox.Text);
                pedidoDb.ClienteId = clienteIdComboBox.SelectedIndex + 1;
                pedidoDb.TrabalhadorId = trabalhadorIdComboBox.SelectedIndex + 1;
                pedidoDb.EstadoId = estadoIdcomboBox.SelectedIndex + 1;
                pedidoDb.RestauranteId = restauranteIdComboBox.SelectedIndex + 1;

                RestGest.SaveChanges();
                LerDados();
            }
            catch
            {
                MessageBox.Show("Os dados não estão com as correções necessárias para proceder à alteração!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
