using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static BlackKiteTask.Models.Enums;

namespace BlackKiteTask.Models
{
    class Companies
    {

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string DomainName { get; set; }

        [EnumDataType(typeof(TypeEnum))]
        public string Type { get; set; }
        public CyberRatings CyberRating { get; set; }
        public ComplianceRatings ComplianceRating { get; set; }
        public FinancialImpacts FinancialImpact { get; set; }
        public string DashboardLink { get; set; }
        public Ecosystems Ecosystem { get; set; }
        public string Country { get; set; }
        public string ScanStatus { get; set; }
    }

}
