using Microsoft.AspNetCore.Identity;

namespace ApiPeliculas.Modelos
{
    public class AppUsuario : IdentityUser
    {
        //Agregar campos personalizados
        public string Nombre { get; set; }
    }
}
