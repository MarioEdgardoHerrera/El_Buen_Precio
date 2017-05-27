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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        
  
        private void button1_Click(object sender, EventArgs e)
        {
            //if (usuarioDal.autenticar(textBox1.Text, textBox2.Text)>0)
            //{
                Form1 menu = new Form1();
                menu.Show();
                this.Hide();

            //}
            //else
            //{
            //    MessageBox.Show("Verifique su contraseña o Nombre de Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reguistrar Crear = new Reguistrar();
            Crear.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
