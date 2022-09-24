using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MTB_Marathon.Tools
{
    public static class Writer
    {
        public static void WriteToCsv(IEnumerable<Models.Racer> racers, string filePathResult)
        {
            var lines = racers.ToList()
                              .Select(r => r.ToCsv());
            File.WriteAllLines(filePathResult, lines);
        }
    }

}
