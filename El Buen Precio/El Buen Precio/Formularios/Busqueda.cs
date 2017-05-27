using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }
        int val = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int indice;

            indice = dataGridView1.CurrentRow.Index;
            Modificar_Producto obMod = new Modificar_Producto();
            obMod.textBox1.Text= Convert.ToString(dataGridView1.Rows[indice].Cells[1].Value);
            obMod.precio_compra.Value = Convert.ToInt32(dataGridView1.Rows[indice].Cells[3].Value);
            obMod.precio_venta.Value = Convert.ToInt32(dataGridView1.Rows[indice].Cells[4].Value);
            obMod.txt_proveedor.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[2].Value);
            obMod.txt_categoria.Text = Convert.ToString(dataGridView1.Rows[indice].Cells[5].Value);
            val= Convert.ToInt32(dataGridView1.Rows[indice].Cells[0].Value);

            obMod.id = val;
            this.Close();
            obMod.Show();
            
        }

        private void llenar()
        {
            MySqlConnection conx = new MySqlConnection("server=localhost;userid=root;password=;database=distribuidora_el_buen_precio");

            MySqlDataAdapter adaptador;
            string consulta = "SELECT * FROM producto";
            DataTable datos = new DataTable();
            conx.Open();
            adaptador = new MySqlDataAdapter(consulta, conx);
            adaptador.Fill(datos);
            dataGridView1.DataSource = datos;
            conx.Close();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            llenar();
        }
    }
}
