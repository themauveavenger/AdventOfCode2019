using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019Tests.Day1
{
    [TestClass]
    public class Day1_Tests
    {
        [TestMethod]
        public void CalculateFuel_Part2_Test1()
        {
            var d = new AdventOfCode2019.Day1();
            List<double> li = new List<double>();
            d.CalculateFuel_Part2(14, ref li);
            Assert.AreEqual(2, li.Sum());
        }

        [TestMethod]
        public void CalculateFuel_Part2_Test2()
        {
            var d = new AdventOfCode2019.Day1();
            List<double> li = new List<double>();
            d.CalculateFuel_Part2(1969, ref li);
            Assert.AreEqual(966, li.Sum());
        }

        [TestMethod]
        public void CalculateFuel_Part2_Test3()
        {
            var d = new AdventOfCode2019.Day1();
            List<double> li = new List<double>();
            d.CalculateFuel_Part2(100756, ref li);
            Assert.AreEqual(50346, li.Sum());
        }
    }
}
