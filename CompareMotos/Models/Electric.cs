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

        public int IgnitionId { get; set; }
        [Required(ErrorMessage = "Adicione qual a ignição da moto")]
        [DisplayName("Ignição")]
        public Ignition Ignition { get; set; }

        public int StartId { get; set; }
        [Required(ErrorMessage = "Adicione qual o tipo de partidada moto")]
        [DisplayName("Partida")]
        public Start Start { get; set; }

        public int BatteryId { get; set; }
        [Required(ErrorMessage = "Adicione qual a bateria moto")]
        [DisplayName("Bateria")]
        public Battery Battery { get; set; }

    }
}
