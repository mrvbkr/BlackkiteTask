using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlackKiteTask.Models
{
    class NewCompany
    {
        [Required]
        public string MainDomainValue { get; set; }
        public string CompanyName { get; set; }
        [Required]
        public Int32 EcosystemId { get; set; }
        public string LicenseType { get; set; } = "ContinuousAnnual";
        public bool IsCloudProvider { get; set; } = false;
        public bool IsSubsidiary { get; set; } = false;
 

    }
}
