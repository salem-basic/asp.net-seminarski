using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class Slika
    {
        [Key]
        public int Id { get; set; }
        public string SlikaProizvoda { get; set; }
        [ForeignKey(nameof(Proizvod))]
        public int? ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
    }
}
