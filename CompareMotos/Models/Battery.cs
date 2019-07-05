using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Battery
    {

        [Key]
        public int BatteryId { get; set; }

        [Required(ErrorMessage = "Adicione tipo de bateria")]
        [DisplayName("Bateria")]
        public string Name { get; set; }

    }
}
