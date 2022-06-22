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
    public partial class Form_IndividualRestaurante : Form
    {

        public static RestGestContainer RestGest;
        public Form_IndividualRestaurante()
        {
            RestGest = new RestGestContainer();
            InitializeComponent();

            LerDadosTrabalhador();
            //LerDadosRestaurante();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCriarTrabalhador_Click(object sender, EventArgs e)
        {
            //Criar Nova Pessoa
            Pessoa pessoa = new Pessoa();
            //Registar
            pessoa.Nome = textBoxNovoTrabalhador.Text;
            pessoa.Telemovel = (long)Convert.ToDouble(textBoxTelemovelTrabalhador.Text);
            pessoa.Ativo = (comboBoxEstadoTrabalhador.Text == "Ativado") ? true : false;


            //Criar Novo Trabalhador
            Trabalhador trabalhador = new Trabalhador();
            //Registar
            trabalhador.Pessoa = pessoa;
            trabalhador.Restaurante = (Restaurante)comboBoxRestauranteTrabalhador.SelectedItem;
            trabalhador.Posicao = textBoxPosicaoTrabalhador.Text;
            trabalhador.Salario = (long)Convert.ToDouble(textBoxSalarioTrabalhador.Text);



            //Criar Novo Trabalhador
            Morada morada = new Morada();
            //Registar
            morada.Rua = textBoxRuaTrabalhador.Text;
            morada.Cidade = textBoxCidadeTrabalhador.Text;
            morada.CodPostal = textBoxCodPostalTrabalhador.Text;
            morada.Pais = textBoxPaisTrabalhador.Text;
            pessoa.Morada = morada;



            RestGest.PessoaSet.Add(trabalhador);
            RestGest.MoradaSet.Add(morada);
            //RestGest.SaveChanges();
            LerDadosTrabalhador();
        }
       


        private void LerDadosTrabalhador()
        {

            Restaurante restaurante = (Restaurante)comboBoxRestauranteTrabalhador.SelectedItem;
            List<Trabalhador> trabalhadores = RestGest.PessoaSet.OfType<Trabalhador>().ToList();

            foreach (Trabalhador trabalhador in trabalhadores)
            {
                if (trabalhador.Restaurante == restaurante)
                {
                    trabalhadores.Add(trabalhador);
                }

            }

            //listBoxTrabalhadores.DataSource = listBoxTrabalhadores;

        }

        private void button1_Click(object sender, EventArgs e)
        {
               //Criar Menu
            //Menu menu = new Menu();
            //Registar
            Menu.Name = textBoxNomeMenu.Text;

            

            //Guardar Alterações
            RestGest.SaveChanges();

          
        }
    }
}
