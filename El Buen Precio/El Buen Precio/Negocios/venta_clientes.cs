using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class venta_clientes
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        

        public venta_clientes() { }

        public venta_clientes(int pID, string pCliente)
        {
            this.ID = pID;
            this.Cliente = pCliente;

        }
    }
}
