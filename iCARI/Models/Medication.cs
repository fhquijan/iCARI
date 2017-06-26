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
    
    public partial class Medication
    {
        public int MedicationId { get; set; }
        public int UserId { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string MedicineRoute { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> PrescribedBy { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual User User { get; set; }
    }
}
