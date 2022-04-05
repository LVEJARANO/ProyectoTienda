using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Categorias
    {
        private int idCategoria;
        private string descripcion;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Categorias(int _idCategoria,string _descripcion)
        {
            idCategoria = _idCategoria;
            descripcion = _descripcion;
        }
    }
}