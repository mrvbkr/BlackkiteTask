using System;
using System.Collections.Generic;
using System.Text;

namespace BlackKiteTask.Models
{
    class CyberRatings
    {
        public string GradeLetter { get; set; }
        public string CyberRating { get; set; }
        public string BreachIndex { get; set; }
        public string RansomwareIndex { get; set; }
        public DateTime? CyberRatingLastUpdatedAt { get; set; }
        public DateTime? RansomwareIndexLastUpdatedAt { get; set; }
        public DateTime? BreachIndexLastUpdatedAt { get; set; }

    }
}
