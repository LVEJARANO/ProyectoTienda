using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Producto
    {
        private int idProducto;
        private string descripcion;
        private double precio;
        private string codigo;
        private int fkCategoria;
        private string descripcionCat;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int FkCategoria

        {

            get { return fkCategoria; }

            set { fkCategoria = value; }

        }

        public int IdProducto

        {

            get { return idProducto; }

            set { idProducto = value; }

        }

        public string DescripcionCat
        {
            get { return descripcionCat; }
            set { descripcionCat = value; }
        }

        public Producto(string _descripcion, double _precio, string _codigo, int _fkCategoria)
        {
            descripcion = _descripcion;
            precio = _precio;
            codigo = _codigo;
            fkCategoria = _fkCategoria;
        }
        public Producto(int _idProducto, string _descripcion, double _precio, string _codigo, int _fkCategoria, string _descripcionCat)
        {
            idProducto = _idProducto;
            descripcion = _descripcion;
            precio = _precio;
            codigo = _codigo;
            fkCategoria = _fkCategoria;
            descripcionCat = _descripcionCat;
        }
        public Producto(int _idProducto, string _descripcion, double _precio, string _codigo, int _fkCategoria)
        {
            idProducto = _idProducto;
            descripcion = _descripcion;
            precio = _precio;
            codigo = _codigo;
            fkCategoria = _fkCategoria;
        }
        public Producto()
        {

        }
    }
}