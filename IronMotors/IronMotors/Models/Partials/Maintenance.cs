using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models
{
    public partial class Maintenance
    {
        public decimal ServiceSum
        {
            get
            {
                if (this.Car.Client.Discount != 0)
                {
                    var serviceSum = this.MaintenanceService.Sum(m => m.Service.Price);
                    var discountSum = (decimal)((double)this.Discount * 0.01);
                    var finishSum = serviceSum * discountSum;
                    return serviceSum - finishSum;
                }
                else
                {
                    return this.MaintenanceService.Sum(m => m.Service.Price);
                }
            }
        }
    }
}
