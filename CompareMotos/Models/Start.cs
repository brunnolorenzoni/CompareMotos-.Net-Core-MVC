using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Start
    {

        [Key]
        public int StartId { get; set; }

        [Required(ErrorMessage = "Adicione tipo de partida")]
        [DisplayName("Partida")]
        public string Name { get; set; }
    }
}
