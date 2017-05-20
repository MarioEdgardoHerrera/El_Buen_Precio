using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace El_Buen_Precio
{
    public partial class Reguistrar : MetroFramework.Forms.MetroForm
    {
        public Reguistrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarusuario pUsuario = new agregarusuario();
            pUsuario.Nombre = textBox1.Text.Trim();
            pUsuario.Contraseña = textBox2.Text.Trim();

            int resultado = agregarusuarioDal.agregar(pUsuario);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Agregado con Exito!!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login Regresar = new Login();
            Regresar.Show();
            this.Hide();
        }
    }
}
