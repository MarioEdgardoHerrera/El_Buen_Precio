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
using MetroFramework.Forms;
namespace El_Buen_Precio
{
    public partial class Buscar_Proveedor : MetroFramework.Forms.MetroForm
    {
        public Buscar_Proveedor()
        {
            InitializeComponent();
        }


        Bd_Distribuidora conec = new Bd_Distribuidora();
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=distribuidora_el_buen_precio; Uid=root; pwd=;");

            conectar.Open();
            string buscar_prov = "SELECT proveedores.id, proveedores.nombre, proveedores.telefono, proveedores.id_distribuidora, proveedores.apellido FROM proveedores  where proveedores.nombre LIKE '" + textBox1.Text + "%'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(buscar_prov, conectar);
            DataTable dtp = new DataTable();
            adaptador.Fill(dtp);
            dataGridView1.DataSource = dtp;
            conectar.Close();
        
        }
    }
}
