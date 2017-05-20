using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class usuarioDal
    {
      /*  public static int crear_cuenta( clase_usuario pusuario)
        {
            int resultado = 0;

            MySqlCommand cmd = new MySqlCommand(string.Format("insert into usurario(nombre,contra) values ('{0}','{1}')", pusuario.Usuario, pusuario.Contraseña), Bd_Distribuidora.ObtenerConexion());

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }*/

        public static int autenticar (string pUsuario, string pContraseña)
        {
            MySqlConnection cox = Bd_Distribuidora.ObtenerConexion();
            int result = -1;

            MySqlCommand cmd = new MySqlCommand(string.Format("Select * From usuario Where nombre = '{0}' and contra = '{1}'", pUsuario, pContraseña), cox);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                result = 50;
            }
            cox.Close();
            return result;
        }
    }
}
