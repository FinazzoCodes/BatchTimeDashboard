using System;
using System.Collections.Generic;
using BatchTimeDashboard.Web.Models;

namespace BatchTimeDashboard.Web.Services
{
    public class FakeRunDataService
    {
        public List<ProcessRun> GetAllRuns()
        {
            return new List<ProcessRun>
            {
                new ProcessRun
                {
                    ProductCode = "187100ABLB",
                    BatchId = "25-320A80",
                    StartTime = DateTime.Parse("2025-06-01 02:10"),
                    EndTime = DateTime.Parse("2025-06-01 04:40")
                },
                new ProcessRun
                {
                    ProductCode = "187100ABLB",
                    BatchId = "25-321A70",
                    StartTime = DateTime.Parse("2025-06-02 01:55"),
                    EndTime = DateTime.Parse("2025-06-02 04:20")
                },
                new ProcessRun
                {
                    ProductCode = "CIP_AB1",
                    BatchId = "CIP001",
                    StartTime = DateTime.Parse("2025-06-03 03:00"),
                    EndTime = DateTime.Parse("2025-06-03 05:00")
                },
                new ProcessRun
                {
                    ProductCode = "CIP_AB1",
                    BatchId = "CIP002",
                    StartTime = DateTime.Parse("2025-06-04 03:15"),
                    EndTime = DateTime.Parse("2025-06-04 05:10")
                }
            };
        }
    }
}
