using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class agregarusuarioDal
    {
        public static int agregar(agregarusuario pUsu)
        {

            int retorno = 0;

            string query = "INSERT INTO `distribuidora_el_buen_precio`.`usuario` (`nombre`, `contra`) VALUES (@nombre, @contraseña);";
            MySqlCommand comando = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@nombre", pUsu.Nombre);
            comando.Parameters.AddWithValue("@contraseña", pUsu.Contraseña);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
