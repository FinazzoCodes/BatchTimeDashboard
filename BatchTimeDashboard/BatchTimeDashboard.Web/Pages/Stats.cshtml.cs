using System.Linq;
using BatchTimeDashboard.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BatchTimeDashboard.Web.Pages
{
    public class StatsModel : PageModel
    {
        private readonly FakeRunDataService _data;

        public StatsModel(FakeRunDataService data)
        {
            _data = data;
        }

        public string? SelectedProduct { get; set; }
        public bool HasResults { get; set; }

        public int RunCount { get; set; }
        public double AverageMinutes { get; set; }
        public double FastestMinutes { get; set; }
        public double SlowestMinutes { get; set; }

        public void OnGet(string? product)
        {
            SelectedProduct = product;

            if (string.IsNullOrEmpty(product))
            {
                HasResults = false;
                return;
            }

            var runs = _data.GetAllRuns()
                            .Where(r => r.ProductCode == product)
                            .ToList();

            if (!runs.Any())
            {
                HasResults = false;
                return;
            }

            HasResults = true;
            RunCount = runs.Count;
            AverageMinutes = runs.Average(r => r.DurationMinutes);
            FastestMinutes = runs.Min(r => r.DurationMinutes);
            SlowestMinutes = runs.Max(r => r.DurationMinutes);
        }
    }
}