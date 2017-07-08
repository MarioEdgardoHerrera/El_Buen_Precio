using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Buen_Precio
{
    public partial class Modificar_Factura : Form

    {
        public Modificar_Factura()
        {
            InitializeComponent();
            dt_facturas.DataSource = facturaDal.listaFacturas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectCodigo = dt_facturas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowExistencias = dt_facturas.Rows[selectCodigo];
            int factura_id = Convert.ToInt32(selectedRowExistencias.Cells["id"].Value);

            facturaDal.anularFactura(factura_id);

            dt_facturas.DataSource = facturaDal.listaFacturas();
        }
    }
}
