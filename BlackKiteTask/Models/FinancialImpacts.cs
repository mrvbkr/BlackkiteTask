using System;
using System.Collections.Generic;
using System.Text;

namespace BlackKiteTask.Models
{
    class FinancialImpacts
    {
        public float? Rating { get; set; }
        public float? RatingMin { get; set; }
        public float? RatingMax { get; set; }
        public float? LossMagnitude { get; set; }
        public float? LossEventFrequency { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

    }
}
