using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class cl_producto
    {
        public int Proveedor_id { get; set; }
        public int Categoria_id { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }



        public cl_producto() { }

        public cl_producto(int pProveedor_Id, int pCategoria_Id, string pNombre_Producto, decimal pPrecio_Compra, decimal pPrecio_Venta)
        {
            this.Proveedor_id = pProveedor_Id;
            this.Categoria_id = pCategoria_Id;
            this.Nombre_Producto = pNombre_Producto;
            this.Precio_Compra = pPrecio_Compra;
            this.Precio_Venta = pPrecio_Venta;
        }
    }
}