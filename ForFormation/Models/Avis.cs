using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForFormation.Models
{
    [Table("Avis")]
    public class Avis
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string rate { get; set; }

        public int FormationsId { get; set; }

        public DateTime DateRating { get; set; }
    }
}
