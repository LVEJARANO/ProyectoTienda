using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Usuario
    {
        private string login;
        private string contrasena;
        private string salt;
        private string tipoUsuario;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }
        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        
        public Usuario (string _login, string _contrasena, string _salt, string _tipoUsuario)
        {
            login = _login;
            contrasena = _contrasena;
            salt = _salt;
            tipoUsuario = _tipoUsuario;
        }
        public Usuario(string _login, string _contrasena, string _salt)
        {
            login = _login;
            contrasena = _contrasena;
            salt = _salt;
        }
        public Usuario()
        {
            
        }
    }
}