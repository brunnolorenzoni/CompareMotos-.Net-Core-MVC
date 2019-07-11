﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Brake
    {
        [Key]
        public int BrakeId { get; set; }

        public int FrontBrakeId { get; set; }
        [Required(ErrorMessage = "Adicione qual o tipo de freio dianteiro")]
        [DisplayName("Freio dianteiro")]
        public FrontBrake FrontBrake { get; set; }

        public int BackBrakeId { get; set; }
        [Required(ErrorMessage = "Adicione qual o tipo de freio traseiro")]
        [DisplayName("Freio traseiro")]
        public BackBrake BackBrake { get; set; }



    }
}
