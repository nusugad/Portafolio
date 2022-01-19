using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioBlogs
    {
        List<BlogDTO> ObtenerBlogs();
    }
    public class RepositorioBlogs : IRepositorioBlogs
    {
        public List<BlogDTO> ObtenerBlogs()
        {
            return new List<BlogDTO>() {

              new BlogDTO
            {
                id = 1,
                Titulo = "Portafolio",
                Texto = "Este proyecto tiene como fin presentar en un solo lugar los diferentes proyectos que he desarrollado. Cada proyecto viene acompañado de un título, descripción, imagen y tres botones que redirigen a la página del proyecto, github y el blog respectivamente. De esta forma es muy fácil para otras personas acceder a toda la información del proyecto. " +
                "Cabe recalcar que el portafolio se realizó con Asp.Net MVC 6 aplicando los principios SOLID con el fin de construir una aplicación organizada y de calidad. No se utiliza ningún tipo de base de datos, es decir, toda la información que maneja la aplicación está en memoria ya que es suficiente para cumplir con las necesidades del proyecto.",
                Imagen = "/img/portafolio.png",
            }
            };
        }
    }
}
