using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models
{
    public partial class Worker
    {
        public string Fullname
        {
            get
            {
                return $"{Lastname} {Firstname}";
            }
        }
    }
}
