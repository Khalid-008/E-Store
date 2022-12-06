using System.ComponentModel.DataAnnotations;

namespace E_Store.Domain.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is require")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is require")]
        public string Phone { get; set; }
    }
}