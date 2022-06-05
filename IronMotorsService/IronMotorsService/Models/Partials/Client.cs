using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotorsService.Models
{
    public partial class Client
    {
        public string Fullname
        {
            get
            {
                return $"{Lastname} {Firstname} {Middlename}";
            }

        }
    }
}
