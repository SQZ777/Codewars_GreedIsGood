using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_23462_Should_Be_0()
        {
            SorceResult(0, new[] { 2, 3, 4, 6, 2 });
        }

        [TestMethod]
        public void Input_52346_Should_Be_50()
        {
            SorceResult(50, new[] { 5, 2, 3, 4, 6 });
        }

        [TestMethod]
        public void Input_12346_Should_Be_100()
        {
            SorceResult(100, new[] { 1, 2, 3, 4, 6 });
        }
        [TestMethod]
        public void Input_12345_Should_Be_150()
        {
            SorceResult(150, new[] { 1, 2, 3, 4, 5 });
        }

        [TestMethod]
        public void Input_22246_Should_Be_150()
        {
            SorceResult(200, new[] { 2, 2, 2, 4, 6 });
        }

        [TestMethod]
        public void Input_22215_Should_Be_150()
        {
            SorceResult(350, new[] { 2, 2, 2, 1, 5 });
        }

        [TestMethod]
        public void Input_33346_Shoud_Be_300()
        {
            SorceResult(300, new[] { 3, 3, 3, 4, 6 });
        }

        [TestMethod]
        public void Input_33315_Should_Be_450()
        {
            SorceResult(450, new[] { 3, 3, 3, 1, 5 });
        }

        [TestMethod]
        public void Input_24446_Shoud_Be_400()
        {
            SorceResult(400, new[] { 2, 4, 4, 4, 6 });
        }

        [TestMethod]
        public void Input_25556_Shoud_Be_500()
        {
            SorceResult(500, new[] { 2, 5, 5, 5, 6 });
        }

        [TestMethod]
        public void Input_23666_Shoud_Be_600()
        {
            SorceResult(600, new[] { 2, 3, 6, 6, 6 });
        }

        [TestMethod]
        public void Input_11146_Shoud_Be_1000()
        {
            SorceResult(1000, new[] { 1, 1, 1, 4, 6 });
        }

        private static void SorceResult(int expected, int[] input)
        {
            var kata = new Kata();
            var actual = kata.Score(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int Score(int[] dice)
        {
            var result = 0;
            result += CountNum(dice, 1) * 100;
            if (CountNum(dice, 2) >= 3)
                result += 200;
            if (CountNum(dice, 3) >= 3)
                result += 300;
            if (CountNum(dice, 4) >= 3)
                result += 400;
            if (CountNum(dice, 5) >= 3)
                result += 500;
            else
                result += CountNum(dice, 5) * 50;
            if (CountNum(dice, 6) >= 3)
                result += 600;

            return result;
        }

        private static int CountNum(int[] dice, int num)
        {
            return Array.FindAll(dice, x => x == num).Count();
        }
    }
}
