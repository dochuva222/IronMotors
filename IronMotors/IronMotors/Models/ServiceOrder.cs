//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IronMotors.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceOrder
    {
        public int Id { get; set; }
        public int CarServiceId { get; set; }
        public int CarId { get; set; }
        public System.DateTime DateTime { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual CarService CarService { get; set; }
    }
}
