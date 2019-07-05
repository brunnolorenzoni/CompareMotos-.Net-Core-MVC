using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Cooling
    {
        [Key]
        public int CoolingId { get; set; }

        [Required(ErrorMessage = "Adicione um tipo de refrigeração")]
        [DisplayName("Refrigeração")]
        public string Name { get; set; }

    }
}
