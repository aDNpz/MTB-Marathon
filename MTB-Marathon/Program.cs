using System;
using MTB_Marathon;
namespace MTB_Marathon.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = @"Data/MTB-Marathon.csv";
            var racers = Tools.Loader.LoadRacers(data);
            Tools.Printer.PrintTop3(racers);
            Tools.Printer.PrintPlaceByAgeGroupedByYear(racers);
            Tools.Printer.PrintAvgTime(racers);
        }
    }
}
