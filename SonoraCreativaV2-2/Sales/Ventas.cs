using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonoraCreativaV2_2.Sales
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void buttonPMenu_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal();
            menu.Show();
            this.Hide();
        }
    }
}
