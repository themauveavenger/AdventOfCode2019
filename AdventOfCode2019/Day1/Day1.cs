using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019
{
    public class Day1 : Day
    {
        string inputPath = "C:\\Users\\jpete\\Documents\\projects\\AdventOfCode2019\\AdventOfCode2019\\Day1\\input.txt";

        public double CalculateFuel(double mass)
        {
            return Math.Floor(mass / 3) - 2;
        }

        public void CalculateFuel_Part2(double mass, ref List<double> calculatedMasses)
        {
            var fuel = CalculateFuel(mass);
            if (fuel < 0)
            {
                // we're done, return everything
                return;
            } else
            {
                // add the calculated fuel to the list, send it down 
                calculatedMasses.Add(fuel);
                CalculateFuel_Part2(fuel, ref calculatedMasses);
            }
        }

        public void Run()
        {
            var input = ReadFileLines(inputPath);

            var totalFuel = input.Select(s => CalculateFuel(Convert.ToDouble(s))).Sum();

            Console.WriteLine($"total fuel: {totalFuel}");
        }

        public void Run_Part2()
        {
            var input = ReadFileLines(inputPath);
            double totalFuel = 0;
            foreach (var line in input)
            {
                var fuel = new List<double>();
                CalculateFuel_Part2(Convert.ToDouble(line), ref fuel);
                totalFuel += fuel.Sum();
            }

            Console.WriteLine($"part 2 --- total fuel: {totalFuel}");
        }
    }
}
