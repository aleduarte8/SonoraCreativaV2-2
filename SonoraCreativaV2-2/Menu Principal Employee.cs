using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonoraCreativaV2_2
{
    public partial class Menu_Principal_Employee : Form
    {
        public Menu_Principal_Employee()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            Inventory.InventarioEmpleado inventario = new Inventory.InventarioEmpleado();
            inventario.Show();
            this.Hide();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            Payment.Cobros cobros = new Payment.Cobros();
            cobros.Show();
            this.Hide();
        }
    }
}
