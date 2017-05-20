using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace El_Buen_Precio
{
    public partial class Inventario : MetroFramework.Forms.MetroForm
    {
        public Inventario()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            //lo que hace este SQL basicamente es usar las relaciones para generar una tabla temporal
            //de los datos de nuestros productos en inventario
            //el @ sirve para dar enter en los strings sin que tire error
            string query = @"SELECT inventario.id, producto.nombre_producto, inventario.cantidad, 
                             producto.precio_compra, producto.precio_venta, producto.id as art_id
                            FROM distribuidora_el_buen_precio.producto
                                INNER JOIN distribuidora_el_buen_precio.inventario ON
                                distribuidora_el_buen_precio.producto.id = distribuidora_el_buen_precio.inventario.producto_id;";

            // Creamos un objeto del tipo datatable para guardar temporarlmente los datos
            DataTable dtDatos = new DataTable();

            //Creamos un data adapter que sirve para traer toda una tabla de la base de datos
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(query, Bd_Distribuidora.ObtenerConexion());

            //esos datos que trae el data adapter los guardamos en el objeto data table
            mdaDatos.Fill(dtDatos);

            // y por ultimo le pasamos esa tabla generada al datagridview
            dataGridView1.DataSource = dtDatos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Disponibilidad Regresar = new Disponibilidad();
            Regresar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto Regresar = new Producto();
            Regresar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vencimiento Regresar = new vencimiento();
            Regresar.Show();
            this.Hide();
        }
    }
}
