using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class Index : System.Web.UI.Page
    {
        ProductoDat objProductoDat = new ProductoDat();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarProductos();
               
            }
        }
        private void mostrarProductos()
        {
            List<Producto> lista = objProductoDat.mostrarProductos();
            gvProductos.DataSource = objProductoDat.mostrarProductos();
            gvProductos.DataBind();
        }
    }
}