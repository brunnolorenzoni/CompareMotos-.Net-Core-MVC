using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class TypeTransmission
    {

        [Key]
        public int TypeTransmissionId { get; set; }

        [Required(ErrorMessage = "Adicione um tipo de transmissão")]
        [DisplayName("Transmissão")]
        public string Name { get; set; }



    }
}
