using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace RestGest
{
    public partial class Form_Menu : Form
    {
        private DB_RestGestDataSet restGest;

        public Form_Menu()
        {
            InitializeComponent();

            restGest = new DB_RestGestDataSet();
            (from menu in restGest.ItemMenuSet orderby menu.Id select menu).Load();

            itemMenuSetBindingSource.DataSource = restGest.ItemMenuSet.Local.ToBindingList();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.CategoriaSet'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaSetTableAdapter1.Fill(this.dB_RestGestDataSet.CategoriaSet);
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.ItemMenuSet'. Você pode movê-la ou removê-la conforme necessário.
            this.itemMenuSetTableAdapter.Fill(this.dB_RestGestDataSet.ItemMenuSet);
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.RestauranteSet'. Você pode movê-la ou removê-la conforme necessário.
            this.restauranteSetTableAdapter.Fill(this.dB_RestGestDataSet.RestauranteSet);
        }

        private void restauranteSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_RestGestDataSet);

        }

        private void buttonNitem_Click(object sender, EventArgs e)
        {
            restGest.SaveChances();
        }
    }
}
