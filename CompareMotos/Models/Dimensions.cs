using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Dimensions
    {
        [Key]
        public int DimensionsId { get; set; }

        [Required(ErrorMessage = "Adicione o comprimento da moto")]
        [DisplayName("Comprimento")]
        public double Length { get; set; }

        [Required(ErrorMessage = "Adicione o largura da moto")]
        [DisplayName("Largura")]
        public double Width { get; set; }

        [Required(ErrorMessage = "Adicione o altura da moto")]
        [DisplayName("Altura")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Adicione o peso da moto")]
        [DisplayName("Peso")]
        public double Weight { get; set; }

    }
}
