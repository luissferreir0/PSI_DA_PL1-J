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
            RestGest = new RestGestContainer();
            LerDados();
        }

        private void LerDados()
        {
            listBoxPedido.DataSource
                = RestGest.PedidoSet.ToList();

            estadoIdcomboBox.DataSource
                = RestGest.EstadoSet.ToList();

            clienteIdComboBox.DataSource
                = RestGest.PessoaSet.ToList();

            trabalhadorIdComboBox.DataSource
                = RestGest.PessoaSet.ToList();

            restauranteIdComboBox.DataSource
                = RestGest.RestauranteSet.ToList();

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
                 pedido.ClienteId = clienteIdComboBox.SelectedIndex;
                 pedido.TrabalhadorId = trabalhadorIdComboBox.SelectedIndex;
                 pedido.EstadoId = estadoIdcomboBox.SelectedIndex;
                 pedido.RestauranteId = restauranteIdComboBox.SelectedIndex;

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
                    (Pedido)listBoxPedido.SelectedItem;
                if (pedido == null)
                {
                    return;
                }

                var pedidoDb = RestGest.PedidoSet.Find(pedido.Id);
                pedidoDb.ValorTotal = (long)Convert.ToDouble(valorTotalTextBox.Text);
                pedidoDb.ClienteId = clienteIdComboBox.SelectedIndex;
                pedidoDb.TrabalhadorId = trabalhadorIdComboBox.SelectedIndex;
                pedidoDb.EstadoId = estadoIdcomboBox.SelectedIndex;
                pedidoDb.RestauranteId = restauranteIdComboBox.SelectedIndex;

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
