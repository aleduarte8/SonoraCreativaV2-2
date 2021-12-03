using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonoraCreativaV2_2.Inventory
{
    public partial class InventarioEmpleado : Form
    {
        public InventarioEmpleado()
        {
            InitializeComponent();
        }

        private void buttonPMenu_Click(object sender, EventArgs e)
        {

        }

        private void InventarioEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioEmpleadosDS.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.inventarioEmpleadosDS.inventario);

        }
    }
}
