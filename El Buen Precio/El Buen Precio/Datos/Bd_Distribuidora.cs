using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace El_Buen_Precio
{
    class Bd_Distribuidora
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=distribuidora_el_buen_precio; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }

    }
}
