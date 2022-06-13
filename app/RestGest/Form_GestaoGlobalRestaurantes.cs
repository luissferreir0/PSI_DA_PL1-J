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
            RestGest = new RestGestContainer();
            LerDados();
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
    }

}
