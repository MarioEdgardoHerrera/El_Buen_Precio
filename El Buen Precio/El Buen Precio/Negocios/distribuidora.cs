using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class distribuidora
    {
         public int ID_Distribuidora { get; set; }
        public string Nombre { get; set; }
      
        public distribuidora() { }
        public distribuidora(int pID_Distribuidora, string pNombre)
        {
            this.ID_Distribuidora = pID_Distribuidora;
            this.Nombre = pNombre;
            
        }
    }
}
