using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class agregarusuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public agregarusuario() { }

        public agregarusuario(int pID_Usuario, string pNombre, string pContraseña)
        {
            this.ID_Usuario = pID_Usuario;
            this.Nombre = pNombre;
            this.Contraseña = pContraseña;
        }
    }
}
