using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class EvidencijaZaposlenika
    {
        [Key]
        public int Id { get; set; }
        public bool Aktivan { get; set; }
        public string Smjena { get; set; }
    }
}
