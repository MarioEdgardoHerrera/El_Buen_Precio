using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class factura
    {
        public int id;
        public string cliente;
        public decimal total;
        public bool estado;

        public factura() {}

        public factura(int fId, string fCliente, decimal fTotal, bool fEstado)
        {
            this.id = fId;
            this.cliente = fCliente;
            this.total = fTotal;
            this.estado = fEstado;
        }

    }
}
