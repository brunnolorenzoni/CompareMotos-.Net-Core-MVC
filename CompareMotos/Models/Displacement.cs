using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Displacement
    {
        [Key]
        public int DisplacementId { get; set; }

        [Required(ErrorMessage = "Adicione quantas cilindradas tem da moto")]
        [DisplayName("Cilindradas")]
        public int Name { get; set; }

    }
}
