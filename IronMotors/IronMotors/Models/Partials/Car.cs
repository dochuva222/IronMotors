using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models
{
    //partial классы дополняют классы которые генерирует адо модель,
    //в них можно писать дополнительную вспомогатльеную логику
    public partial class Car
    {
        public byte[] RandomImage
        {
            get
            {
                var imageCount = this.CarImage.Count;
                if (imageCount > 0)
                {
                    var random = new Random();
                    return this.CarImage.ToList()[random.Next(0, this.CarImage.Count)].Image;

                }
                else
                    return null;
            }
        }

        public string CarFullname
        {
            get
            {
                return $"{this.Model.CarBrand.Name} {this.Model.Name} {this.NumberPlate}";
            }
        }
    }
}
