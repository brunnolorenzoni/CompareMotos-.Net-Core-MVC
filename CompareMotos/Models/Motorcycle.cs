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
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [DisplayName("Ano")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Adicione o valor da moto")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int EngineId { get; set; }
        public Engine Engine { get; set; }

        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }

        public int ElectricId { get; set; }
        public Electric Electric  { get; set;}

        public int BrakeId { get; set; }
        public Brake Brake { get; set;}

        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set;}

        public int DimensionsId { get; set; }
        public Dimensions Dimensions { get; set; }

    }
}
