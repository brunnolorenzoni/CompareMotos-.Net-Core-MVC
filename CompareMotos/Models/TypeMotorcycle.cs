using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class TypeMotorcycle
    {

        [Key]
        public int TypeMotorcycleId { get; set; }

        [Required(ErrorMessage = "Adicione qual o tipo da moto")]
        [DisplayName("Tipo de moto")]
        public string Name { get; set; }

    }
}
