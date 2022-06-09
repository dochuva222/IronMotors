using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models.Metadata
{
    public class UserMetadata
    {
        [Required, MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MaxLength(50)]
        public string Lastname { get; set; }
        [Required, MaxLength(50)]
        public string Middlename { get; set; }
        [Required, MaxLength(50)]
        public string Login { get; set; }
        [Required, MaxLength(50)]
        public string Password { get; set; }
    }
}
