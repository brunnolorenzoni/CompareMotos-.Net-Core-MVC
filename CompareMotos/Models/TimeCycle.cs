using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class TimeCycle
    {

        [Key]
        public int TimeCycleId { get; set; }

        [Required(ErrorMessage = "Adicione quantos tempos é o motor")]
        [DisplayName("Tempo")]
        public int Name { get; set; }

    }
}
