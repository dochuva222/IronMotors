﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models.Metadata
{
    public class ServiceMetadata
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
