using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class TypeFuel
    {
        [Key]
        public int TypeFuelId { get; set; }

        [Required(ErrorMessage = "Adicione qual o tipo de combustivel")]
        [DisplayName("Tipo de combustivel")]
        public string Name { get; set; }
    }
}
