using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace El_Buen_Precio
{
    class proveedoresDal
    {
        public static int agregar(proveedor pproveedores)
        {


            int retorno = 0;

            string query = "INSERT INTO `distribuidora_el_buen_precio`.`proveedores` (`nombre`, `apellido`, `telefono`) VALUES (@nombre, @apellido, @tel);";
            MySqlCommand comando = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@nombre", pproveedores.Nombre_Proveedor);
            comando.Parameters.AddWithValue("@apellido", pproveedores.Apellido_Proveedor);
            comando.Parameters.AddWithValue("@tel", pproveedores.Numero_Telf_Proveedor);
          
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }
}
