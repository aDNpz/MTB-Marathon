using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Extensions;

namespace MTB_Marathon.Tools
{
    public static class Loader
    {
        public static IEnumerable<Models.Racer> LoadRacers(string filePath)
        {
            filePath.CheckArgument(nameof(filePath));
            return File.ReadAllLines(filePath, encoding: System.Text.Encoding.Default)
                        .Select(l => l.Split(";"))
                        .Select(d => new Models.Racer
                        {
                            //5;Andrejek Erich;64;AUT;03:41:05
                            ID = Convert.ToInt32(d[0]),
                            Name = d[1],
                            Age = Convert.ToInt32(d[2]),
                            Nation = d[3],
                            Time = TimeSpan.Parse(d[4])
                        });
        }
    }
}
