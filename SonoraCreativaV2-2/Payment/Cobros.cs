using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonoraCreativaV2_2.Payment
{
    public partial class Cobros : Form
    {
        public Cobros()
        {
            InitializeComponent();
        }

        private void buttonPMenu_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal();
            menu.Show();
            this.Hide();
        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cobrosIdItemListDS.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.cobrosIdItemListDS.inventario);

        }
    }
}
