using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class Transakcija
    {
        [Key]
        public int Id { get; set; }
        public int BrojTransakcije { get; set; }
        public DateTime DatumTransakcije { get; set; }

        [ForeignKey(nameof(Valuta))]
        public int? ValutaId { get; set; }
        public Valuta Valuta { get; set; }

        [ForeignKey(nameof(Kartica))]
        public int? KarticaId { get; set; }
        public Kartica Kartica { get; set; }
        public string VrstaTransakcije { get; set; }

        [ForeignKey(nameof(Narudzba))]
        public int? NarudzbaId { get; set; }
        public Narudzba Narudzba { get; set; }
    }
}
