using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoMusicas.Models
{
    [Table("tb_musica")]
    public class Musica : Audio
    {
        [Key]
        public int IdMusica { get; set; }
        public  string Album { get; set; }
        public string Artista { get; set; }
        public string Genero { get; set; }
    }
}
