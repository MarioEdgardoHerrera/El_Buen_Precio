using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class clase_usuario
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public clase_usuario () { }

        public clase_usuario (string pUsuario, string pContraseña)
        {
            this.Usuario = pUsuario;
            this.Contraseña = pContraseña;
        }
    }
}
