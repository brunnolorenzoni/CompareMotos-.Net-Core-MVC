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
        public TypeTransmission TypeTransmission { get; set; }

        [Required(ErrorMessage = "Adicione quantas marchas tem da moto")]
        [DisplayName("Marchas")]
        public AmountGear AmountGear { get; set; }

    }
}
