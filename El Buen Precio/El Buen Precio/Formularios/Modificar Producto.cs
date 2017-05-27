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
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    public partial class Modificar : MetroFramework.Forms.MetroForm
    {
        public int id = 0;
        MySqlConnection conx = new MySqlConnection("server=localhost;userid=root;password=;database=distribuidora_el_buen_precio");


        public Modificar()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Busqueda objbusq = new Busqueda();
            objbusq.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("modificar_producto", conx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p1", textBox1.Text);
                cmd.Parameters.AddWithValue("p2", Convert.ToInt32(txt_proveedor.Text));
                cmd.Parameters.AddWithValue("p3", precio_compra.Value);
                cmd.Parameters.AddWithValue("p4", precio_venta.Value);
                cmd.Parameters.AddWithValue("p5", Convert.ToInt32(txt_categoria.Text));
                cmd.Parameters.AddWithValue("p6", id);

                conx.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Datos actualizados", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conx.Close();
                }
                else
                {

                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conx.Close();
                }
                conx.Close();

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conx.Close();
            }

        }

        
    }


}

