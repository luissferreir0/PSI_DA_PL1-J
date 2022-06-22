using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class Form_Menu : Form
    {
        public static RestGestContainer RestGest;
        public byte[] bytePhoto;

        public Form_Menu()
        {
            InitializeComponent();
        }

        private void LerDados()
        {
            listBoxMenu.DataSource
                = RestGest.ItemMenuSet.ToList();

            categoriaIdComboBox.DataSource
                = RestGest.CategoriaSet.ToList();

        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            RestGest = new RestGestContainer();
            LerDados();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            RestGest.Dispose();
        }

        private void photobutton_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.photo.Multiselect = true;
            this.photo.Title = "Selecionar Fotos";
            photo.InitialDirectory = @"C:\Users\macoratti\Pictures";
            //filtra para exibir somente arquivos de imagens
            photo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            photo.CheckFileExists = true;
            photo.CheckPathExists = true;
            photo.FilterIndex = 2;
            photo.RestoreDirectory = true;
            photo.ReadOnlyChecked = true;
            photo.ShowReadOnly = true;

            DialogResult dr = this.photo.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in photo.FileNames)
                {
                    bytePhoto = Encoding.UTF8.GetBytes(arquivo);
                    // cria um PictureBox
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Height = 100;
                        pb.Width = 100;
                        //atribui a imagem ao PictureBox - pb
                        pb.Image = Imagem;
                        //inclui a imagem no containter flowLayoutPanel
                        fotografiaPictureBox.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                        "Mensagem : " + ex.Message + "\n\n" +
                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem : " + arquivo.Substring(arquivo.LastIndexOf('\\'))
                                        + ". Você pode não ter permissão para ler o arquivo , ou " +
                                        " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }//fim e evento botão

        private void buttonNitem_Click(object sender, EventArgs e)
        {
            ItemMenu menu = new ItemMenu();
            
            try
            {
                menu.Nome = nomeTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                menu.Ingredientes = ingredientesTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            try
            {
                menu.Preco = Convert.ToDecimal(precoTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                menu.Fotografia = bytePhoto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            try
            {
                menu.CategoriaId = categoriaIdComboBox.SelectedIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            bool ativo;

            if (ativoCheckBox.Checked)
            {
                ativo = false;
            }
            else
            {
                ativo = true;
            }

            try
            {
                menu.Ativo = ativo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            RestGest.ItemMenuSet.Add(menu);
            
            try 
            { 
                RestGest.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LerDados();
        }

        private void buttonAitem_Click(object sender, EventArgs e)
        {
            ItemMenu menu =
                (ItemMenu)listBoxMenu.SelectedItem;

            try
            {
                menu.Nome = nomeTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso! Erro No Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                menu.Ingredientes = ingredientesTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso! Erro Nos Ingredientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            try
            {
                menu.Preco = Convert.ToDecimal(precoTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso! Erro No Preço", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                menu.Fotografia = bytePhoto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso! Erro Na Foto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            try
            {
                menu.CategoriaId = categoriaIdComboBox.SelectedIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso! Erro Na Categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            bool ativo;

            if (ativoCheckBox.Checked)
            {
                ativo = false;
            }
            else
            {
                ativo = true;
            }

            try
            {
                menu.Ativo = ativo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso! Erro no Estado do Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            RestGest.ItemMenuSet.Add(menu);

            try
            {
                RestGest.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possível salvar.\n Erro: " + ex.Message, "Aviso! Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LerDados();
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemMenu menu =
                    (ItemMenu)listBoxMenu.SelectedItem;
            if (menu == null)
            {
                return;
            }

            nomeTextBox.Text = menu.Nome;
            ingredientesTextBox.Text = menu.Ingredientes;
            precoTextBox.Text = menu.Preco.ToString();

            if (menu.Ativo == true)
            {
                ativoCheckBox.Checked = true;
            }
            else
            {
                ativoCheckBox.Checked = false;
            }
        }
    }
}
