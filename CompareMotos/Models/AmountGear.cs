using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class AmountGear
    {

        [Key]
        public int AmountGearId { get; set; }

        [Required(ErrorMessage = "Adicione uma quantidade de marchas")]
        [DisplayName("Marchas")]
        public int Amount{ get; set; }

    }
}
