using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SeminarskiTest.Models
{
    public class Slika
    {
        [Key]
        public int Id { get; set; }
        public string SlikaSlika { get; set; }
    }
}
