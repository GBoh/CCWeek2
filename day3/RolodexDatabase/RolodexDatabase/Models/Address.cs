using System.ComponentModel.DataAnnotations;

namespace RolodexDatabase.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}$")]
        public string Zip { get; set; }
    }
}