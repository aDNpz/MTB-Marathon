using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTB_Marathon.Tools
{
    public static class Printer
    {
        public static void PrintTop3(IEnumerable<Models.Racer> racers)
        {
            var result = racers.OrderBy(r => r.Time)
                  .Take(3)
                  .ToList();
            result.ForEach(r =>
            {
                Console.WriteLine($"{r}");
            });
        }
        public static void PrintAvgTime(IEnumerable<Models.Racer> racers)
        {
            var avg = racers.Average(r => r.Time.TotalMinutes);
            Console.WriteLine($"{avg.ToString()}");
        }

        public static void PrintPlaceByAgeGroupedByYear(IEnumerable<Models.Racer> racers)
        {
            racers.OrderBy(r => r.Age)
                  .ThenBy(r => r.Time)
                  .GroupBy(r => r.Age)
                  .ToList()
                  .ForEach(r =>
                  {
                      Console.WriteLine($"{r.Key}");
                      r.ToList()
                        .ForEach(r => Console.WriteLine($"\t{r}"));
                  });
        }
    }
}
