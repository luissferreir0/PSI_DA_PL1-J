using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

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
            Pedido pedido = new Pedido();

            try
            {
                pedido.ValorTotal = (long)Convert.ToDouble(valorTotalTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Erro no Valor Total", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                pedido.ClienteId = clienteIdComboBox.SelectedIndex;
            }
            catch
            {
                MessageBox.Show("Erro na escolha de Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                pedido.TrabalhadorId = trabalhadorIdComboBox.SelectedIndex;
            }
            catch
            {
                MessageBox.Show("Erro na escolha de Trabalhador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                pedido.EstadoId = estadoIdcomboBox.SelectedIndex;
            }
            catch
            {
                MessageBox.Show("Erro no Estado do Pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                pedido.RestauranteId = restauranteIdComboBox.SelectedIndex;
            }
            catch
            {
                MessageBox.Show("Erro na escolha de Restaurante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            RestGest.PedidoSet.Add(pedido);

            if (string.IsNullOrEmpty(valorTotalTextBox.Text))
            {
                return;
            }
            
            RestGest.PedidoSet.Add(pedido);

            try
            { 
                 RestGest.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.. Erro reportado : " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LerDados();
            

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
