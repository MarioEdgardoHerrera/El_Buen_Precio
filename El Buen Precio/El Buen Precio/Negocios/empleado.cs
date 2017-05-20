using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Buen_Precio
{
    class empleado
    {
        public int ID_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Apellido_Empleado { get; set; }
        public string Numero_Telf_Empleado { get; set; }
        public string Estado_Civil { get; set; }
        public string Direccion { get; set; }

        public empleado() { }

        public empleado(int pID_Empleado, string pNombre_Empleado, string pApellido_Empleado, string pNumero_Telf_Empleado, string pEstado_Civil, string pDireccion)
        {
            this.ID_Empleado = pID_Empleado;
            this.Nombre_Empleado = pNombre_Empleado;
            this.Apellido_Empleado = pApellido_Empleado;
            this.Numero_Telf_Empleado = pNumero_Telf_Empleado;
            this.Estado_Civil = pEstado_Civil;
            this.Direccion = pDireccion;

        }
    }
}
