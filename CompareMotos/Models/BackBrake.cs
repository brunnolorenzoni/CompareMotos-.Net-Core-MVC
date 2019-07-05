using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class BackBrake
    {

        [Key]
        public int BackBrakeeId { get; set; }

        [Required(ErrorMessage = "Adicione o tipo de freio")]
        [DisplayName("Freio")]
        public string Name { get; set; }

    }
}
