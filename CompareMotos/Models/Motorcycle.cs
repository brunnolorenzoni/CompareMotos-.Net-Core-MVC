using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMotos.Models
{
    public class Motorcycle
    {

        [Key]
        public int MotorcycleId { get; set; }

        [Required(ErrorMessage = "Adicione o ano da moto")]
        [DisplayName("Ano")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Adicione o valor da moto")]
        [DataType(DataType.Currency)]
        [DisplayName("Preço")]
        public double Price { get; set; }

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

        [DisplayName("Tipo")]
        public int TypeMotorcycleId { get; set; }
        public TypeMotorcycle TypeMotorcycle { get; set; }

        [DisplayName("Marca")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        [DisplayName("Modelo")]
        public int ModelMotorcycleId { get; set; }
        public ModelMotorcycle ModelMotorcycle { get; set; }

        [DisplayName("Cilindradas")]
        public int DisplacementId { get; set; }
        public Displacement Displacement { get; set; }



    }
}
