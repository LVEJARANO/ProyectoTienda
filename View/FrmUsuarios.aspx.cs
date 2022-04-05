using Datos;
using Model;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class FrmUsurios : System.Web.UI.Page
    {
        UsuarioDat objUsuarioDat = new UsuarioDat();
        private bool ejecuto = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string contrasena = txtContrasena.Text;
            ICryptoService cryptoService = new PBKDF2();
            string salt = cryptoService.GenerateSalt();
            string contrasenaEncriptada = cryptoService.Compute(contrasena);

            Usuario objUsuario = new Usuario(txtUsuario.Text, contrasenaEncriptada, salt, ddlTipoUsuario.Text);
            ejecuto = objUsuarioDat.guardarUsuarios(objUsuario);

            if (ejecuto)
            {
                lblMsj.Text = "El usuario se guardo exitosamente!";
            }
            else
            {
                lblMsj.Text = "Error al guardar el usuario!";
            }


        }
    }
}