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
                return MaintenanceService.Sum(m => m.Service.Price);
            }
        }
    }
}
