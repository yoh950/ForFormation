using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForFormation.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="Le nom doit être renseigner")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="Votre Email doit être renseigner")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="Ecrivez un message")]
        public string Message { get; set; }
    }
}
