using System;
using System.Collections.Generic;
namespace MTB_Marathon.Models
{
    public sealed class Racer
    {
        //5;Andrejek Erich;64;AUT;03:41:05
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nation { get; set; }
        public TimeSpan Time { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name} {Age} {Nation} {Time}";
        }

        public string ToCsv()
        {
            return $"{ID};{Name};{Age};{Nation};{Time}";
        } 
    }
}
