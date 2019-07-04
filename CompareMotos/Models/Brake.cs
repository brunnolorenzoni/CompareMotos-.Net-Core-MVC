using System;
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

        [Required(ErrorMessage = "Adicione qual o tipo de freio dianteiro")]
        [DisplayName("Freio dianteiro")]
        public string Front { get; set; }

        [Required(ErrorMessage = "Adicione qual o tipo de freio traseiro")]
        [DisplayName("Freio traseiro")]
        public string Back { get; set; }



    }
}
