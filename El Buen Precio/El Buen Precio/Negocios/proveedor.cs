using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class proveedor
    {
        public int ID_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Apellido_Proveedor { get; set; }
        public string Numero_Telf_Proveedor { get; set; }

        public proveedor() { }

        public proveedor(int pID_Proveedor, string pNombre_Proveedor, string pApellido_Proveedor, string pNumero_Telf_Proveedor)
        {
            this.ID_Proveedor = pID_Proveedor;
            this.Nombre_Proveedor = pNombre_Proveedor;
            this.Apellido_Proveedor = pApellido_Proveedor;
            this.Numero_Telf_Proveedor = pNumero_Telf_Proveedor;
        }

    }
}
