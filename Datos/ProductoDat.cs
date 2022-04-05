using Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Datos
{
    public class ProductoDat
    {
        private string conexion;
        public ProductoDat()
        {
            this.conexion = ConfigurationManager.ConnectionStrings["Conn"].ToString();
        }
        //Metodo para listar todos los Productos
        public List<Producto> mostrarProductos()
        {
            List<Producto> lista = new List<Producto>();
            using (MySqlConnection c = new MySqlConnection(this.conexion))
            {
                c.Open();
                MySqlCommand command = c.CreateCommand();
                command.CommandText = "SELECT tbl_productos.id_productos,tbl_productos.descripcion,"+
                    "tbl_productos.precio,tbl_productos.codigo,tbl_productos.tbl_categoria_id_categoria,tbl_categoria.descripcion as desCategoria" + "" +
                    " FROM tbl_productos inner join tbl_categoria on tbl_productos.tbl_categoria_id_categoria = tbl_categoria.id_categoria";
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return lista;
                }

                while (reader.Read())
                {
                    lista.Add(new Producto(int.Parse(reader["id_productos"].ToString()), reader["descripcion"].ToString(),
                        double.Parse(reader["precio"].ToString()), reader["codigo"].ToString(), int.Parse(reader["tbl_categoria_id_categoria"].ToString()), reader["desCategoria"].ToString()));
                }
                c.Close();
            }

            return lista;

        }

        //Metodo para guardar Productos
        public bool guardarProductos(Producto prod)
        {
            bool ejecuto = false;
            using (MySqlConnection conexion = new MySqlConnection(this.conexion))
            {
                conexion.Open();
                MySqlCommand command = conexion.CreateCommand();
                command.CommandText = "INSERT INTO TBL_PRODUCTOS(DESCRIPCION, PRECIO, CODIGO, TBL_CATEGORIA_ID_CATEGORIA) VALUES ('" + prod.Descripcion + "', " + prod.Precio + ",'" + prod.Codigo + "', " + prod.FkCategoria + ")";

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

        //Metodo para actualizar un Producto
        public bool actualizarProductos(Producto prod)
        {
            bool ejecuto = false;
            using (MySqlConnection conexion = new MySqlConnection(this.conexion))
            {
                conexion.Open();
                MySqlCommand command = conexion.CreateCommand();
                command.CommandText = "UPDATE TBL_PRODUCTOS SET DESCRIPCION = '" + prod.Descripcion + "'," +
                    "PRECIO = '" + prod.Precio + "',CODIGO='" + prod.Codigo + "'," +
                    "TBL_CATEGORIA_ID_CATEGORIA='" + prod.FkCategoria + "' WHERE ID_PRODUCTOS ='" + prod.IdProducto + "'";

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

        //Metodo para eliminar un Producto
        public bool eliminarProducto(int idProducto)
        {
            bool ejecuto = false;
            using (MySqlConnection conexion = new MySqlConnection(this.conexion))
            {
                conexion.Open();
                MySqlCommand command = conexion.CreateCommand();
                command.CommandText = "DELETE FROM TBL_PRODUCTOS WHERE ID_PRODUCTOS ='" + idProducto + "'";

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
    }
}