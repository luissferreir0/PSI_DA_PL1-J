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
        public Form_Pedidos()
        {
            InitializeComponent();
        }

        private void itemMenuSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemMenuSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_RestGestDataSet);

        }

        private void Form_Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.EstadoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoSetTableAdapter.Fill(this.dB_RestGestDataSet.EstadoSet);
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.PedidoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoSetTableAdapter.Fill(this.dB_RestGestDataSet.PedidoSet);
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.MetodoPagamentoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.metodoPagamentoSetTableAdapter.Fill(this.dB_RestGestDataSet.MetodoPagamentoSet);
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.ItemMenuSet'. Você pode movê-la ou removê-la conforme necessário.
            this.itemMenuSetTableAdapter.Fill(this.dB_RestGestDataSet.ItemMenuSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_GestaoClientes fclientes = new Form_GestaoClientes();
            fclientes.Show();
        }
    }
}
