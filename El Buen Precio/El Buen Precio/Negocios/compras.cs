using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class compras
    {
        public int Empleado_id { get; set; }
        public int Cantidad { get; set; }
        public int Inventario_id { get; set; }
        public DateTime fecha_compra = new DateTime();
        public DateTime fecha_vencimiento = new DateTime();
       
        public compras() { }

        public compras(int pEmpleado_Id, int pCantidad, int pInventario_Id, DateTime pfecha_compra, DateTime pfecha_vencimiento)
        {
            this.Empleado_id = pEmpleado_Id;
            this.Cantidad = pCantidad;
            this.Inventario_id = pInventario_Id;
            this.fecha_compra = pfecha_compra;
            this.fecha_vencimiento = pfecha_vencimiento;
        }
    }
}
