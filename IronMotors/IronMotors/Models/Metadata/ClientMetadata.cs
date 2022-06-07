using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models.Metadata
{
    public class ClientMetadata
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Firstname { get; set; }
        [MaxLength(50), Required]
        public string Lastname { get; set; }
        [MaxLength(11), Required]
        public string PhoneNumber { get; set; }
    }
}
