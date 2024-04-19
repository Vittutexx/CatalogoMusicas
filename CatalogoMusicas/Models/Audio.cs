using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoMusicas.Models
{
    public abstract class Audio
    {
        public string Titulo { get; set; }
        public int TotalReproducoes { get; set; }
        public int TotalCurtidas { get; set; }
        public int Classificacao {  get; set; }

    }
}
