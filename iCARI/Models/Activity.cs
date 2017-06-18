using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace iCARI.Models
{
    public class Activity
    {
        [DisplayName("ID")]
        public int RecordId { get; set; }

        [DisplayName("Subject")]
        public string Subject { get; set; }

        [DisplayName("Contact")]
        public string Contact { get; set; }

        [DisplayName("Activity Date")]
        public DateTime ActivityDate { get; set; }

        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("Activity Type")]
        public string ActivityType { get; set; }

        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DisplayName("Group Created")]
        public string GroupCreated { get; set; }

        [DisplayName("Created By")]
        public string CreatedBy { get; set; }
        
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }


    }
}