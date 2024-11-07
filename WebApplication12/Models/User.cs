using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(0, 150)]
        public int Age { get; set; }
    }
}
