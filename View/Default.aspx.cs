using Datos;
using Model;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class Default1 : System.Web.UI.Page
    {
        UsuarioDat objUsuarioDat = new UsuarioDat();
        Usuario usu = new Usuario();
        private bool ejecuto = false;
        private string usuario, contrasena;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ICryptoService cryptoService = new PBKDF2();
            usuario = txtUsuario.Text;
            contrasena = txtContrasena.Text;

            usu = objUsuarioDat.consultarUsuario(usuario);

            if (usu != null)
            {
                string passEncryp = cryptoService.Compute(contrasena, usu.Salt);
                if (cryptoService.Compare(usu.Contrasena, passEncryp))
                {
                    FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, true);
                }
                else
                {
                    lblMsj.Text = "Usuario o Contraseña Incorrectos!";
                }
            }
            else
            {
                lblMsj.Text = "Usuario o Contraseña Incorrectos!";
            }
        }
    }
}