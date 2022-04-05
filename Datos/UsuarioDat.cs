using Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Datos
{
    public class UsuarioDat
    {
        private string conexion;
        public UsuarioDat()
        {
            this.conexion = ConfigurationManager.ConnectionStrings["Conn"].ToString();
        }

        //Metodo para guardar Usuarios
        public bool guardarUsuarios(Usuario usu)
        {
            bool ejecuto = false;
            using (MySqlConnection conexion = new MySqlConnection(this.conexion))
            {
                conexion.Open();
                MySqlCommand command = conexion.CreateCommand();
                command.CommandText = "INSERT INTO TBL_USUARIOS(USUARIO, CONTRASENA, SALT, TIPO) VALUES ('" + usu.Login + "', '" + usu.Contrasena + "','" + usu.Salt + "', '" + usu.TipoUsuario + "')";

                try
                {
                    if (command.ExecuteNonQuery() != 0)
                    {
                        ejecuto = true;
                    }
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                finally
                {
                    conexion.Close();
                }

                return ejecuto;
            }
        }

        public Usuario consultarUsuario(string usuario)
        {
            Usuario usu = null;
            List<Usuario> lista = new List<Usuario>();
            using (MySqlConnection c = new MySqlConnection(this.conexion))
            {
                c.Open();
                MySqlCommand command = c.CreateCommand();
                command.CommandText = "SELECT USUARIO,CONTRASENA,SALT FROM TBL_USUARIOS WHERE USUARIO ='" + usuario + "'";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(usu = new Usuario(reader["usuario"].ToString(), reader["contrasena"].ToString(), reader["salt"].ToString()));
                }
                c.Close();
            }
            return usu;
        }
    }
}