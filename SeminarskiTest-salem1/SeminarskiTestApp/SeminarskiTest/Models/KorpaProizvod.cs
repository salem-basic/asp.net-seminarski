using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class KorpaProizvod
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Proizvod))]
        public int? ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
       // [ForeignKey(nameof(Valuta))]
        public int? ValutaId { get; set; }
        public Valuta Valuta { get; set; }
        public double Popust { get; set; }
        public int Kolicina { get; set; }
        public bool Stanje { get; set; }
    }
}
