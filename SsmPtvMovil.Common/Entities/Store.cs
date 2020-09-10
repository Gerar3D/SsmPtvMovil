﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SsmPtvMovil.Common.Entities
{
    public class Store
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} must contain less than {1} characteres")]
        [Required]
        public string Name { get; set; }
    }
}