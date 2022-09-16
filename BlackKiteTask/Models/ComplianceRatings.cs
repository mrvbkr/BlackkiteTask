using System;
using System.Collections.Generic;
using System.Text;

namespace BlackKiteTask.Models
{
    class ComplianceRatings
    {
        public Int32? Rating { get; set; }

        public Int32? Confidence { get; set; }
        public Int32? Completeness { get; set; }
        public DateTime LastUpdatedAt { get; set; }
            }
}
