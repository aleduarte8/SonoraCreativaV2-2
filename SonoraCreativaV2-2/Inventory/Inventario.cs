using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonoraCreativaV2_2.Inventory
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            textBoxProductName.Text = "";
            textBoxProductDescription.Text = "";
            comboBoxProducttype.Text = "Selecciona una opcion";
            textBoxQuantity.Text = "";
            textBoxPrice.Text = "";

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPMenu_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal();
            menu.Show();
            this.Hide();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDS.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter1.Fill(this.inventarioDS.inventario);


        }

        private void buttonCleanFields_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            int contadorcampos = 0;
            int pcantidad = 0;
            if (!(textBoxProductName.Text.Equals(""))&!(comboBoxProducttype.Text.Equals("Selecciona una opcion")))
            {
                contadorcampos++;
            }
            if (!(textBoxPrice.Text.Equals("")))
            {
                contadorcampos++;
            }
            else
            {
                MessageBox.Show("Favor de introducir un precio", "Precio no reconocido", MessageBoxButtons.OK);
            }
            if (!(textBoxQuantity.Text.Equals("")))
            {
                pcantidad= Int32.Parse(textBoxQuantity.Text);
            }
            if (contadorcampos == 2)
            {
                SqlConnection Conexion = ConnectionsSQL.ConexionSCDB.ObtenerConexion();

                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO inventario (nombre,descripcion,tipo_producto,cantidad,precio) VALUES ('{0}', '{1}','{2}','{3}','{4}')",
                    textBoxProductName.Text, textBoxProductDescription.Text, comboBoxProducttype.Text, pcantidad, float.Parse(textBoxPrice.Text)), Conexion);

                int resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente el producto", "Registro guardado", MessageBoxButtons.OK);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se registro correctamente el producto", "Registro no guardado", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Favor de rellenar todos los campos obligatorios (*)", "Error al registrar el producto", MessageBoxButtons.OK);
            }
        }
    }
}
