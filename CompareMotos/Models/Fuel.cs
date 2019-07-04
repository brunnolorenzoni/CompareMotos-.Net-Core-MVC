using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Fuel
    {

        [Key]
        public int FuelId { get; set; }

        [Required(ErrorMessage = "Adicione qual a capacidade do tanque da moto")]
        [DisplayName("Capacidade do tanque")]
        public double Capacity { get; set; }

        [Required(ErrorMessage = "Adicione qual o tipo de combustivel")]
        [DisplayName("Tipo de combustivel")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Adicione qual o tipo de alimentação")]
        [DisplayName("Alimentação")]
        public string Feeding { get; set; }

    }
}
