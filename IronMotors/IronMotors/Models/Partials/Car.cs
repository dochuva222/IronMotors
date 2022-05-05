using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models
{
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
    }
}
