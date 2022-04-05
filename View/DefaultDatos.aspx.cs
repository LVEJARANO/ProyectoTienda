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
    public partial class Default : System.Web.UI.Page
    {
        ProductoDat objProductoDat = new ProductoDat();
        CategoriaDat objCategoriaDat = new CategoriaDat();
        private bool ejecuto = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarProductos();
                mostrarCategorias();
            }
            btnActualizar.Enabled = false;
        }

        private void mostrarProductos()
        {
            List<Producto> lista = objProductoDat.mostrarProductos();
            gvProductos.DataSource = objProductoDat.mostrarProductos();
            gvProductos.DataBind();
        }
        private void mostrarCategorias()
        {
            ddlCategoria.DataSource = objCategoriaDat.mostrarCategorias();
            ddlCategoria.DataValueField = "idCategoria";
            ddlCategoria.DataTextField = "descripcion";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, "Seleccione");
        }
        private void limpiarCampos()
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Text = "";
            ddlCategoria.SelectedIndex = 0;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Producto objProducto = new Producto(txtDescripcion.Text, double.Parse(txtPrecio.Text), txtCodigo.Text, int.Parse(ddlCategoria.SelectedValue.ToString()));
            ejecuto = objProductoDat.guardarProductos(objProducto);

            if (ejecuto)
            {
                lblMsj.Text = "El producto se guardo Exitosamente!";
                mostrarProductos();
                limpiarCampos();
            }
            else
            {
                lblMsj.Text = "Erro al guardar el producto!";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto(int.Parse(txtId.Text), txtDescripcion.Text, double.Parse(txtPrecio.Text),
                txtCodigo.Text, int.Parse(ddlCategoria.SelectedValue.ToString()));

            ejecuto = objProductoDat.actualizarProductos(objProducto);

            if (ejecuto)
            {
                lblMsj.Text = "El producto se actualizo exitosamente!";
                mostrarProductos();
                limpiarCampos();
                btnGuardar.Enabled = true;
            }
            else
            {
                lblMsj.Text = "Error al actualizar el producto!";
            }
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtDescripcion.Text = gvProductos.SelectedRow.Cells[1].Text;
            txtPrecio.Text = gvProductos.SelectedRow.Cells[2].Text;
            txtCodigo.Text = gvProductos.SelectedRow.Cells[3].Text;
            ddlCategoria.SelectedValue = gvProductos.SelectedRow.Cells[4].Text;
            txtId.Text = gvProductos.SelectedRow.Cells[5].Text;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;

        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idProducto = Convert.ToInt32(gvProductos.DataKeys[e.RowIndex].Values[0]);
            ejecuto = objProductoDat.eliminarProducto(idProducto);

            if (ejecuto)
            {
                lblMsj.Text = "El producto se elimino exitosamente";
            }
            else
            {
                lblMsj.Text = "Error al eliminar el producto";
            }
            gvProductos.EditIndex = -1;
            mostrarProductos();
        }
    }
}