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
        [Required]
        public int YearOfIssue { get; set; }

        [Required]
        public virtual Model Model { get; set; }
    }
}
