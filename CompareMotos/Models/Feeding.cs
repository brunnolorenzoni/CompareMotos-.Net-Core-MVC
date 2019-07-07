using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Feeding
    {

        [Key]
        public int FeedingId { get; set; }

        [Required(ErrorMessage = "Adicione qual o tipo de alimentação")]
        [DisplayName("Tipo de alimentação")]
        public string Name { get; set; }

    }
}
