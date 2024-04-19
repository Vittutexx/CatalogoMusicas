using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoMusicas.Models
{
    [Table("tb_podcast")]
    public class Podcast : Audio
    {
        [Key]
        public int IdPodcast { get; set; }

        [MaxLength(80)]
        public string Host { get; set; }
        
        public string Descricao { get; set; }
    }
}
