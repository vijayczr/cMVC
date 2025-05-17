using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string? First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
