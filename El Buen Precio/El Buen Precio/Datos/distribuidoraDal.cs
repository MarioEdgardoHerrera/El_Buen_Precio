using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class distribuidoraDal
    {
        public static int agregar(distribuidora pdistribuidora)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into distribuidora (nombre) values ('{0}')",
            pdistribuidora.Nombre), Bd_Distribuidora.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;


        }
    }
}
