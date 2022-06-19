using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models
{
    public partial class Client
    {
        public string Fullname
        {
            get
            {
                return $"{Lastname} {Firstname} {PhoneNumber}";
            }
        }

        public int Discount
        {
            get
            {
                int discount = 0;
                var maintenanceCount = this.Car.SelectMany(c => c.Maintenance).Count();
                if (maintenanceCount >= 5 && maintenanceCount < 10)
                    discount = 5;
                if (maintenanceCount >= 10 && maintenanceCount < 15)
                    discount = 10;
                if (maintenanceCount >= 15)
                    discount = 15;
                return discount;
            }
        }
    }
}
