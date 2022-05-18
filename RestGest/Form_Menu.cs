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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_RestGestDataSet.RestauranteSet'. Você pode movê-la ou removê-la conforme necessário.
            this.restauranteSetTableAdapter.Fill(this.dB_RestGestDataSet.RestauranteSet);
        }

        private void restauranteSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_RestGestDataSet);

        }
    }
}
