using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotorsService.Models
{
    public partial class Car
    {
        public string CarFullname
        {
            get
            {
                return $"{this.CarBrand.Name} {this.Model} {this.NumberPlate}";
            }
        }
    }
}
