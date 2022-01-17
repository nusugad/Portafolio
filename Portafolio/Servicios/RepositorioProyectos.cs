/*Un repositorio se encarga de servir datos.*/

using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos() 
        {
            return new List<ProyectoDTO>() {

              new ProyectoDTO
            {
                Titulo = "Portafolio",
                Descripcion = "Portafolio desarrollado en ASP.NET MVC 6 aplicando los principios SOLID.",
                Imagen = "/img/portafolio.png",
                Link = "https://portafolionicolasusuga.azurewebsites.net/",
                LinkGit = "https://github.com/nusugad/Portafolio/"
            }
            };
        }
    }
}
