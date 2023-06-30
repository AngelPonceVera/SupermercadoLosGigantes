using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenedor_de_almacenamiento
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtContraseña.Text == "Acceso")
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("No se encuentra su Usuario o Contraseña", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                txtContraseña.Text = string.Empty;
                txtUsuario.Text = string.Empty;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
