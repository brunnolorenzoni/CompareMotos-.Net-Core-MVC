using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Ignition
    {

        [Key]
        public int IgnitionId { get; set; }

        [Required(ErrorMessage = "Adicione tipo de ignição")]
        [DisplayName("Ignição")]
        public string Name { get; set; }

    }
}
