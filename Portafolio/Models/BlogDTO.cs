/*contiene los datos de un blog*/

namespace Portafolio.Models
{
    public class BlogDTO
    { 
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagen { get; set; }
    }
}
