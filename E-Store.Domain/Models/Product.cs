﻿using System.ComponentModel.DataAnnotations;

namespace E_Store.Domain.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is require")]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}