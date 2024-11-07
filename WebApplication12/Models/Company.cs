using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
