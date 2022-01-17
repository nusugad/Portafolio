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
                Texto = "In semper, eros a varius hendrerit, libero nisl tincidunt diam, id gravida risus nulla ac est. " +
                "Etiam ac posuere lorem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed diam volutpat, " +
                "luctus ante eu, euismod sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac " +
                "turpis egestas. Ut eu placerat purus, non egestas leo. Etiam ut vestibulum sapien. Orci varius natoque " +
                "penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse potenti.",
                Imagen = "/img/portafolio.png",
            }
            };
        }
    }
}
