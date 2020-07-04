using IdentityModel;
using Login.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace Login.Seguridad
{
    public class IdentityPersonalizado : IIdentity
    {
        public string Name
        {
            get { return Login; }
        }

        public string AuthenticationType
        {
            get { return Identity.AuthenticationType; }
        }
        
        public bool IsAuthenticated
        {
            get { return Identity.IsAuthenticated; }
        }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public IIdentity Identity { get; set; }

        public IdentityPersonalizado(IIdentity identity)
        {
            this.Identity = identity;
            var us = Membership.GetUser(Identity.Name) as MembresiaUsuario;

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