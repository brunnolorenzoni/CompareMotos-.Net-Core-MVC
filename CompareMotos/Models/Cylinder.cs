using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Cylinder
    {

        [Key]
        public int CylinderId { get; set; }

        [Required(ErrorMessage = "Adicione quantas cilindros")]
        [DisplayName("Cilindros")]
        public int Name { get; set; }

    }
}
