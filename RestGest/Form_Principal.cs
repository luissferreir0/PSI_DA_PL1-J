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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void button_menus_Click(object sender, EventArgs e)
        {
            Form_Menu form_Menu = new Form_Menu();
            form_Menu.ShowDialog();
        }
    }
}
