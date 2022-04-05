using Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Datos
{
    public class CategoriaDat
    {
        private string conexion;
        public CategoriaDat()
        {
            this.conexion = ConfigurationManager.ConnectionStrings["Conn"].ToString();
        }

        public List<Categorias> mostrarCategorias()
        {
            List<Categorias> lista = new List<Categorias>();

            using (MySqlConnection c = new MySqlConnection(this.conexion))
            {
                c.Open();
                MySqlCommand command = c.CreateCommand();
                command.CommandText = "SELECT * FROM tbl_categoria;";
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                    return lista;
                while (reader.Read())
                {
                    lista.Add(new Categorias(int.Parse(reader["id_categoria"].ToString()),
                        reader["descripcion"].ToString()));
                }
                c.Close();
            }
            return lista;

        }
    }
}