using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA2_CRUD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text; string contrasena = txtContrasena.Text;
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=miBaseDeDatos;Integrated Security=True;Encrypt=False;";
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario); cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    connection.Open(); int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    { // Login exitoso, abrir el formulario principal
                        frmCrud mainForm = new frmCrud();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }

        }

    }
}
        