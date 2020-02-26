﻿using System.ComponentModel.DataAnnotations;

namespace Nursoft.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
    }
}