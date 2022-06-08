using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models.Metadata
{
    public class MaintenanceMetadata
    {
        public int Id { get; set; }
        public System.DateTime DateTime { get; set; }
        [Required]
        public virtual Car Car { get; set; }
    }
}
