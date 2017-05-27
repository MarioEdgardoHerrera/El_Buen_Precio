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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores Nuevo = new Proveedores();

            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados Nuevo = new Empleados();

            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void entradasProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra Nuevo = new Compra();

            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias Nuevo = new Categorias();

            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto Nuevo = new Producto();

            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario Nuevo = new Inventario();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disponibilidad Nuevo = new Disponibilidad();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void distribuidoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Distribuidoras Nuevo = new Distribuidoras();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Proveedor Nuevo = new Buscar_Proveedor();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }
        
        private void proveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            proveedor__de__producto Nuevo = new proveedor__de__producto();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void ventaFacturadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venta_cliente Nuevo = new venta_cliente();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void vencidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vencimiento Nuevo = new vencimiento();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Salir = new Login();
            Salir.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modificar_Producto objModfi = new Modificar_Producto();
            objModfi.MdiParent = this;
            objModfi.Show();
        }
    }
}
