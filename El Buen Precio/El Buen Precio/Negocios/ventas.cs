using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class ventas
    {
        public int articulo_id { get; set; }
        public int cantidad { get; set; }
       

        public ventas() { }

        public ventas(int particulo_id, int pcantidad)
        {
            this.articulo_id = particulo_id;
            this.cantidad = pcantidad;
            
        }
    }
}
