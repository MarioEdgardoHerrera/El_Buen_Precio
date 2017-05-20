using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class categoria
    {
        public int ID_Categoria { get; set; }
        public string Nombre { get; set; }
      
        public categoria() { }

        public categoria(int pID_Categoria, string pNombre)
        {
            this.ID_Categoria = pID_Categoria;
            this.Nombre = pNombre;
            
        }
    }
}
