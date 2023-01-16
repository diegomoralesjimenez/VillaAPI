﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }
        public int Ocuppancy { get; set; }
        public int Sqft { get; set; }
        public string ImageURL { get; set; }
        public string Amenity { get; set; }
    }
}
