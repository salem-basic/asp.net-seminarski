using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class Narudzba
    {
        [Key]
        public int Id { get; set; }
        public DateTime DatumNarudzbe { get; set; }

        public int? ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
        public string KorisnikID { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
