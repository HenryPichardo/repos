using Login.Models;
using Login.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Login.Seguridad
{
    public class MembresiaUsuario:MembershipUser
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public MembresiaUsuario(Usuario us)
        {
            IdUsuario = us.IdUsuario;
            Nombre = us.Nombre;
            Apellidos = us.Apellidos;
            Email = us.Email;
            Telefono = us.Telefono;
            Login = us.Login;
            Password = SeguridadUtilidades.GetSha1(us.Password);

        }
    }
}