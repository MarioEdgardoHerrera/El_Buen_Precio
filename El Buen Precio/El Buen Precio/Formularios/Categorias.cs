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
    public partial class Categorias : MetroFramework.Forms.MetroForm
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoria pcategoria = new categoria();
            pcategoria.Nombre = textBox1.Text.Trim();

            int resultado = categoriaDal.agregar(pcategoria);
            if (resultado > 0)
            {
                MessageBox.Show("Categoria Agregada con Exito!!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar la Categoria", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
