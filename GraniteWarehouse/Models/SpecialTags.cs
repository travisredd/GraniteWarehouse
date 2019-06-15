﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GraniteWarehouse.Models
{
    public class SpecialTags
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}