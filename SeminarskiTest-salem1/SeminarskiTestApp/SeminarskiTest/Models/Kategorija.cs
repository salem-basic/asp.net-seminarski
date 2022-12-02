using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class Kategorija
    {
        [Key]
        public int Id { get; set; }
        public string NazivKategorije { get; set; }
    }
}
