using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class Korpa
    {
        [Key]
        public int Id { get; set; }

        public ICollection<KorpaProizvod> KorpaProizvods { get; set; }
    }
}
