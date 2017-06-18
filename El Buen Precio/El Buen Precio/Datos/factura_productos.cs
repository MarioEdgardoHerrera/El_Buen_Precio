using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class factura_productos
    {
        public int id;
        public int producto_id;
        public decimal cantidad;
        public int factura_id;
        public decimal total;

        factura_productos() { }

        factura_productos(int fpId, int fpProducto_Id, decimal fpCantidad, int fpFactura_id, decimal ttotal)
        {
            this.id = fpId;
            this.producto_id = fpProducto_Id;
            this.cantidad = fpCantidad;
            this.factura_id = fpFactura_id;
            this.total = ttotal;
        }
    }
}
