using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class categoriaDal
    {
        public static int agregar(categoria pcategoria)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into categorias (Nombre) values ('{0}')",
            pcategoria.Nombre), Bd_Distribuidora.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;


        }
    }
}
