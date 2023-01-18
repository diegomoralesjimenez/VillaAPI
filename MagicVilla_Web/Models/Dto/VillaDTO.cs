﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_WebModels.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }

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
