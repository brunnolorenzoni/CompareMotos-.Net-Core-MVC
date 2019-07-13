using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Brand
    {

        [Key]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Adicione a marca da moto")]
        [DisplayName("Marca da moto")]
        public string Name { get; set; }

    }
}
