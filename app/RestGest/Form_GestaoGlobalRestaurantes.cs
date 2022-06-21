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
    public partial class Form_GestaoGlobalRestaurantes : Form
    {
        RestGestContainer RestGest;
        public Form_GestaoGlobalRestaurantes()
        {
            InitializeComponent();
        }
        private void Form_GestaoGlobalRestaurantes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.PedidoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoSetTableAdapter.Fill(this.dB_RestGestDataSet.PedidoSet);
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.EstadoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoSetTableAdapter.Fill(this.dB_RestGestDataSet.EstadoSet);
            RestGest = new RestGestContainer();
            LerDados();
            LerDadosCategorias();
            LerDadosPagamentos();
        }

        private void LerDados()
        {
            listBoxGlobalRestaurantes.DataSource = RestGest.RestauranteSet.ToList();
        }

        private void Form_GestaoGlobalRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            RestGest.Dispose();
        }

        private void buttonCriarRestaurantes_Click(object sender, EventArgs e)
        {
            //Criar Novo Restaurante
            Morada restauranteMorada = new Morada();
            Restaurante restaurante = new Restaurante();
            
            //Registar Morada Restaurante
            restauranteMorada.Cidade =textBoxCidade.Text;
            restauranteMorada.Rua=textBoxRua.Text;
            restauranteMorada.CodPostal =textBoxCodPostal.Text;
            restauranteMorada.Pais=textBoxPais.Text;

            RestGest.MoradaSet.Add(restauranteMorada);

            restaurante.Nome = textBoxNomeRestauranteNovo.Text;
            restaurante.Morada = restauranteMorada;

            if (string.IsNullOrEmpty(textBoxNomeRestauranteNovo.Text) || string.IsNullOrEmpty(textBoxCidade.Text) || string.IsNullOrEmpty(textBoxRua.Text) || string.IsNullOrEmpty(textBoxCodPostal.Text) || string.IsNullOrEmpty(textBoxPais.Text))
                {
                return;
            }

            RestGest.RestauranteSet.Add(restaurante);
            RestGest.SaveChanges();
            LerDados();
        }

       

        private void buttonRemoverRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante selectedRestaurante = (Restaurante)listBoxGlobalRestaurantes.SelectedItem;
            if (selectedRestaurante == null)
            {

                return;
            }
           
            //Remover o cliente associado a base dados
            RestGest.RestauranteSet.Remove(selectedRestaurante);
            //Guardar alteraçoes na base de dados
            RestGest.SaveChanges();
            // Atualizar Dados de restaurantes existentes
            listBoxGlobalRestaurantes.DataSource = null;
            LerDados();
        }

        private void listBoxGlobalRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante restaurante =
                (Restaurante)listBoxGlobalRestaurantes.SelectedItem;
            if(restaurante == null)
            {
                return ;
            }

                textBoxAlterarNome.Text = restaurante.Nome;
            textBoxAlterarCidade.Text = restaurante.Morada.Cidade;
            textBoxAlterarRua.Text = restaurante.Morada.Rua;
            textBoxAlterarCodPostal.Text = restaurante.Morada.CodPostal;
            textBoxAlterarPais.Text = restaurante.Morada.Pais;



        

        }

        private void buttonAlterarDados_Click(object sender, EventArgs e)
        {
            Restaurante restaurante =
                   (Restaurante)listBoxGlobalRestaurantes.SelectedItem;
            if (restaurante == null)
            {
                return;
            }
            

            var restauranteDb = RestGest
                .RestauranteSet.Find(restaurante.Id);
            restauranteDb.Nome = textBoxAlterarNome.Text;
            restauranteDb.Morada.Cidade = textBoxAlterarCidade.Text;
            restauranteDb.Morada.Rua = textBoxAlterarRua.Text;
            restauranteDb.Morada.CodPostal = textBoxAlterarCodPostal.Text;
            restauranteDb.Morada.Pais = textBoxAlterarPais.Text;
          

            RestGest.SaveChanges();
            LerDados();

        }


        private void LerDadosCategorias()
        {
            listBoxCategoriasMenu.DataSource = RestGest.CategoriaSet.ToList();
            
        }


        private void buttonCriarCategoria_Click(object sender, EventArgs e)
        {


             //Criar nova Categoria
                Categoria categoria = new Categoria();
                categoria.Nome = textBoxMenuCategoria.Text;
                categoria.Ativo = (comboBoxCategoriaEstado.Text == "Ativado") ? true : false;

                RestGest.CategoriaSet.Add(categoria);
                RestGest.SaveChanges();
                LerDadosCategorias();
            
    
        }

        private void listBoxCategoriasMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Categoria categoria =
              (Categoria)listBoxCategoriasMenu.SelectedItem;
            if (categoria == null)
            {
                return;
            }

            textBoxMenuCategoria.Text = categoria.Nome;
           // comboBoxCategoriaEstado.SelectedIndex = categoria.Ativo ? 0:1;

        }

        private void buttonRemoverCategoria_Click(object sender, EventArgs e)
        {
            Categoria selectedCategoria = (Categoria)listBoxCategoriasMenu.SelectedItem;
            if (selectedCategoria == null)
            {

                return;
            }

            //Remover a categoria associado a base dados
            RestGest.CategoriaSet.Remove(selectedCategoria);
            //Guardar alteraçoes na base de dados
            RestGest.SaveChanges();
            // Atualizar Dados de Categoria existentes
            listBoxCategoriasMenu.DataSource = null;
            LerDadosCategorias();
        }

        private void comboBoxCategoriaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonAlterarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria =
             (Categoria)listBoxCategoriasMenu.SelectedItem;
            if (categoria == null)
            {
                return;
            }


            var categoriaDb = RestGest
                .CategoriaSet.Find(categoria.Id);
            categoriaDb.Nome = textBoxMenuCategoria.Text;
            categoriaDb.Ativo = (comboBoxCategoriaEstado.Text == "Ativado") ? true : false;



            RestGest.SaveChanges();
            LerDadosCategorias();
        }

        private void buttonMetodosPagamento_Click(object sender, EventArgs e)
        {
            //Criar novo Pagameto
            MetodoPagamento metodoPagamento = new MetodoPagamento();
            metodoPagamento.MetodoP = textBoxMetodoPagamento.Text;
            metodoPagamento.Ativo = (comboBoxMetodoPagamentoAtivo.Text == "Ativado") ? true : false;

            RestGest.MetodoPagamentoSet.Add(metodoPagamento);
            RestGest.SaveChanges();
            LerDadosPagamentos();

        }

        private void LerDadosPagamentos()
        {
            listBoxMetodosPagamentos.DataSource = RestGest.MetodoPagamentoSet.ToList();

        }

        private void buttonRemoverMetodoPagamento_Click(object sender, EventArgs e)
        {
            MetodoPagamento selectedMetodoPagamento = (MetodoPagamento)listBoxMetodosPagamentos.SelectedItem;
            if (selectedMetodoPagamento == null)
            {

                return;
            }

            //Remover a categoria associado a base dados
            RestGest.MetodoPagamentoSet.Remove(selectedMetodoPagamento);
            //Guardar alteraçoes na base de dados
            RestGest.SaveChanges();
            // Atualizar Dados de Categoria existentes
            listBoxCategoriasMenu.DataSource = null;
            LerDadosPagamentos();
        }

        private void buttonAterarPagamentos_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento =
             (MetodoPagamento)listBoxMetodosPagamentos.SelectedItem;
            if (metodoPagamento == null)
            {
                return;
            }


            var cmetodoPagamentoaDb = RestGest
                .MetodoPagamentoSet.Find(metodoPagamento.Id);
            cmetodoPagamentoaDb.MetodoP = textBoxMetodoPagamento.Text;
            cmetodoPagamentoaDb.Ativo = (comboBoxMetodoPagamentoAtivo.Text == "Ativado") ? true : false;



            RestGest.SaveChanges();
            LerDadosPagamentos();
        }

        private void listBoxMetodosPagamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento =
              (MetodoPagamento)listBoxMetodosPagamentos.SelectedItem;
            if (metodoPagamento == null)
            {
                return;
            }

            textBoxMetodoPagamento.Text = metodoPagamento.MetodoP;
            // comboBoxMetodoPagamentoAtivo.SelectedIndex = categoria.Ativo ? 0:1;

        }
    }

}
