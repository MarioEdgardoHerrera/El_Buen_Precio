using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class empleadoDal
    {
        public static int agregar(empleado pempleados)
        {

            int retorno = 0;

            string query = "INSERT INTO `distribuidora_el_buen_precio`.`emplados` (`nombre`, `apellido`, `telefono`, `estado_civil`, `dirección`) VALUES (@nombre, @apellido, @tel, @est_civ, @dir);";
            MySqlCommand comando = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@nombre", pempleados.Nombre_Empleado);
            comando.Parameters.AddWithValue("@apellido", pempleados.Apellido_Empleado);
            comando.Parameters.AddWithValue("@tel", pempleados.Numero_Telf_Empleado);
            comando.Parameters.AddWithValue("@est_civ", pempleados.Estado_Civil);
            comando.Parameters.AddWithValue("@dir", pempleados.Direccion);
            retorno = comando.ExecuteNonQuery();
            return retorno;

            
        }
    }
}
