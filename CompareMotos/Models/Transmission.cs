using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Transmission
    {
        [Key]
        public int TransmissionId { get; set; }

        [Required(ErrorMessage = "Adicione o tipo da tramissão da moto")]
        [DisplayName("Tipo")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Adicione quantas marchas tem da moto")]
        [DisplayName("Marchas")]
        public int Gear { get; set; }

    }
}
