using System;

namespace PortalTeleMedicina.WebAPI.ViewModels
{
    public class UsuarioSignupVM : UsuarioSigninVM
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
    }
}
