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
    public partial class Form_GestaoClientes : Form
    {
        public static RestGestContainer RestGest;
        public Form_GestaoClientes()
        {
            InitializeComponent();
        }
        private void Form_GestaoClientes_Load(object sender, EventArgs e)
        {
            RestGest = new RestGestContainer();
            LerDados();
        }
  
        private void LerDados()
        {
            listBoxClientes.DataSource
                = RestGest.PessoaSet.ToList();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RestGest.Dispose();
        }
        private void buttonRemoverCliente_Click(object sender, EventArgs e) // Remover Cliente
        {
            Cliente selectedClient =
              (Cliente)listBoxClientes.SelectedItem;
            if (selectedClient == null)
            {
                return;
            }

            RestGest.PessoaSet.Remove(selectedClient);
            RestGest.SaveChanges();           
            listBoxClientes.DataSource = null;
            LerDados();
        }

        private void buttonCriarCliente_Click(object sender, EventArgs e) // Criar Cliente
        {
            Cliente cliente = new Cliente();
            Morada clienteMorada = new Morada();
            Pessoa pessoa = new Pessoa();

            clienteMorada.Cidade = textBoxCidade.Text;
            clienteMorada.CodPostal = textBoxCP.Text;
            clienteMorada.Rua = textBoxRua.Text;
            clienteMorada.Pais = textBoxPais.Text;

            RestGest.MoradaSet.Add(clienteMorada);
                        
            cliente.Telemovel = (long)Convert.ToDouble(textBoxTelemovel.Text); 
            cliente.Nome = textBoxNome.Text;
            cliente.NumContribuinte = (long)Convert.ToDouble(textBoxContribuinte.Text);
            cliente.Morada = clienteMorada;

            RestGest.PessoaSet.Add(cliente);

            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxTelemovel.Text) || string.IsNullOrEmpty(textBoxCP.Text) || string.IsNullOrEmpty(textBoxCidade.Text) || string.IsNullOrEmpty(textBoxPais.Text) || string.IsNullOrEmpty(textBoxRua.Text) || string.IsNullOrEmpty(textBoxContribuinte.Text))
            {
                return;
            }
            RestGest.PessoaSet.Add(cliente);

            RestGest.SaveChanges();

            LerDados();

        }
       
        private void buttonAlterarDados_Click(object sender, EventArgs e) // Alterar Dados dos Clientes
        {
            Cliente cliente =
                (Cliente)listBoxClientes.SelectedItem;
            if (cliente == null)
            {
                return;
            }
            
           
            var clienteDb = RestGest
                .PessoaSet.Find(cliente.Id);
            clienteDb.Nome = textBoxNome.Text;
            clienteDb.Telemovel = (long)Convert.ToDouble(textBoxTelemovel.Text);
            clienteDb.Morada.CodPostal = textBoxCP.Text;
            clienteDb.Morada.Cidade = textBoxCidade.Text;
            clienteDb.Morada.Pais = textBoxPais.Text;
            clienteDb.Morada.Rua = textBoxRua.Text;
            cliente.NumContribuinte = (long)Convert.ToDouble(textBoxContribuinte.Text);

            

            RestGest.SaveChanges();
            LerDados();

        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e) //Selecionar Dados na ListBox
        {
            Cliente cliente =
            (Cliente)listBoxClientes.SelectedItem;
            if (cliente == null)
            {
                return;
            }

            textBoxNome.Text = cliente.Nome;
            textBoxTelemovel.Text = cliente.Telemovel.ToString();
            textBoxCP.Text = cliente.Morada.CodPostal;
            textBoxCidade.Text = cliente.Morada.Cidade;
            textBoxPais.Text = cliente.Morada.Pais;
            textBoxRua.Text = cliente.Morada.Rua;
            textBoxContribuinte.Text = cliente.NumContribuinte.ToString();

        }
    }
}
