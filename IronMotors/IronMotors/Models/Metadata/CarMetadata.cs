using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models.Metadata
{
    //метадата это класс который нужен для реализации валидации
    //свойства берутся копируются из модели 
    //нужному свойству добавляются аттрибуты Required(обязательное поле) maxlength(максимальная длина строки) и тп.
    public class CarMetadata
    {
        public int Id { get; set; }
        [Required]
        public string NumberPlate { get; set; }
        public int CarBrandId { get; set; }
        [Required, MaxLength(50)]
        public string Model { get; set; }
        [Required]
        public int YearOfIsuue { get; set; }
        public int ClientId { get; set; }
        [Required]
        public int MileageInKilometres { get; set; }

        [Required]
        public virtual CarBrand CarBrand { get; set; }


    }
}
