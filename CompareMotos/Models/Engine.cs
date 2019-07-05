using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Engine
    {

        [Key]
        public int EngineId { get; set; }

        [Required(ErrorMessage = "Adicione quantos tempos tem a moto")]
        [DisplayName("Tempo")]
        public TimeCycle TimeCycle { get; set; }

        [Required(ErrorMessage = "Adicione quantos cilindros tem da moto")]
        [DisplayName("Cilindros")]
        public Cylinder Cylinder { get; set; }

        [Required(ErrorMessage = "Adicione quantas cilindradas tem da moto")]
        [DisplayName("Cilindradas")]
        public Displacement Displacement { get; set; }

        [Required(ErrorMessage = "Adicione a refrigeração da moto")]
        [DisplayName("Refrigeração")]
        public Cooling Cooling { get; set; }

    }
}
