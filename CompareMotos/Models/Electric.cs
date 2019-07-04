using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Electric
    {

        [Key]
        public int ElectricId { get; set; }

        [Required(ErrorMessage = "Adicione qual a ignição da moto")]
        [DisplayName("Ignição")]
        public string Ignition { get; set; }

        [Required(ErrorMessage = "Adicione qual o tipo de partidada moto")]
        [DisplayName("Partida")]
        public string Start { get; set; }

        [Required(ErrorMessage = "Adicione qual a bateria moto")]
        [DisplayName("Bateria")]
        public string Battery { get; set; }

    }
}
