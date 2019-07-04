﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Model
    {

        [Key]
        public int ModelId { get; set; }

        [Required(ErrorMessage = "Adicione o modelo da moto")]
        [DisplayName("Modelo")]
        public string Name { get; set; }
    }
}
