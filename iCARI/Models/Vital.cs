//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iCARI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vital
    {
        public int VitalId { get; set; }
        public int UserId { get; set; }
        public string BloodPressure { get; set; }
        public string HeartRate { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string BMI { get; set; }
    
        public virtual User User { get; set; }
    }
}
