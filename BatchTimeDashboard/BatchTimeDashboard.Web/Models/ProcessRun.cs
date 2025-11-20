using System;

namespace BatchTimeDashboard.Web.Models
{
    public class ProcessRun
    {
        public string ProductCode { get; set; } = "";
        public string BatchId { get; set; } = "";
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Auto-calculated property for duration
        public double DurationMinutes => (EndTime - StartTime).TotalMinutes;
    }
}
