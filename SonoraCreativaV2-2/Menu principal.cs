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
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Inventory.Inventario inventario = new Inventory.Inventario();
            inventario.Show();
            this.Hide();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Users.Usuarios usuarios = new Users.Usuarios();
            usuarios.Show();
            this.Hide();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            Payment.Cobros cobros = new Payment.Cobros();
            cobros.Show();
            this.Hide();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            Sales.Ventas ventas = new Sales.Ventas();
            ventas.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
