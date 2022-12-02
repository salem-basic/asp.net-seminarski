using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class Brend
    {
        [Key]
        public int Id { get; set; }
        public string NazivBrenda { get; set; }

    }
}
