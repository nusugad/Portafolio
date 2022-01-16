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
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.Net Core",
                Imagen = "/img/Corte1.jpg",
                Link = "https://amazon.com"
            }
            };
        }
    }
}
