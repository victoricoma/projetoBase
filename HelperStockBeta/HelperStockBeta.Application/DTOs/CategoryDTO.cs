﻿using System.ComponentModel.DataAnnotations;

namespace HelperStockBeta.Application.DTOs
{
    public class CategoryDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
