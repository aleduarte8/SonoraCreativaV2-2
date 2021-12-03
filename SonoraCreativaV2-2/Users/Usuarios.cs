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

namespace SonoraCreativaV2_2.Users
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();   
        }
        public void Limpiar()
        {
            textBoxName.Text = "";
            textBoxPLastname.Text = "";
            textBoxMLastname.Text = "";
            textBoxUsername.Text = "";
            comboBoxUsertype.Text = "Seleccione una opcion";
            textBoxPassword.Text = "";
            textBoxCPassword.Text = "";
            comboBoxSchedule.Text = "Seleccione una opcion";
            textBoxNotes.Text = "";
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarioGVDS.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.usuarioGVDS.usuarios);

        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            String lastname=null;
            int contadorcampos = 0;
            if (!(textBoxPLastname.Text.Equals("")) & !(textBoxMLastname.Text.Equals("")))
            {
                lastname = textBoxPLastname.Text +" "+ textBoxMLastname.Text;
                contadorcampos++;
            }
            else if(!(textBoxPLastname.Text.Equals("")) & textBoxMLastname.Text.Equals(""))
            {
                lastname = textBoxPLastname.Text;
                contadorcampos++;
            }
            else if (textBoxPLastname.Text.Equals("") & !(textBoxMLastname.Text.Equals("")))
            {
                lastname = textBoxPLastname.Text;
                contadorcampos++;
            }

            if (!(textBoxName.Text.Equals("")) & !(textBoxUsername.Text.Equals("")) & !(comboBoxUsertype.Text.Equals("Seleccione una opcion")) & !(comboBoxSchedule.Text.Equals("Seleccione una opcion")))
            {
                contadorcampos++;
            }

            if (textBoxPassword.Text.Equals(textBoxCPassword.Text) & !(textBoxPassword.Text.Equals("")))
            {
                contadorcampos++;
            }
            else
            {
                MessageBox.Show("Favor de verificar las constraseñas","Las contraseñas no coinciden", MessageBoxButtons.OK);
            }

            if (contadorcampos == 3)
            {
                SqlConnection Conexion = ConnectionsSQL.ConexionSCDB.ObtenerConexion();

                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO usuarios (nombre,apellidos,apodo,tipo_usuario,contrasena,turno,notas) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')",
                    textBoxName.Text, lastname, textBoxUsername.Text,comboBoxUsertype.Text,textBoxPassword.Text,comboBoxSchedule.Text,textBoxNotes.Text), Conexion);
                
                int resultado= comando.ExecuteNonQuery();

                Conexion.Close();

                if (resultado>0)
                {
                    MessageBox.Show("Se registro correctamente al usuario", "Registro guardado", MessageBoxButtons.OK);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se registro correctamente al usuario", "Registro no guardado", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Favor de rellenar todos los campos obligatorios (*)", "Error al registrar el usuario", MessageBoxButtons.OK);
            }
        }

        private void buttonPMenu_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal();
            menu.Show();
            this.Hide();
        }

        private void buttonCleanFields_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
