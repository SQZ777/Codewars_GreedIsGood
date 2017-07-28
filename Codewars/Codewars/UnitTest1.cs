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
        public void Input_14446_Shoud_Be_300()
        {
            SorceResult(400, new[] { 1, 4, 4, 4, 6 });
        }

        [TestMethod]
        public void Input_33315_Should_Be_450()
        {
            SorceResult(450, new[] { 3, 3, 3, 1, 5 });
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
            result += CountNum(dice, 5) * 50;
            result += CountNum(dice, 1) * 100;
            if (CountNum(dice, 2) >= 3)
                result += 200;
            if (CountNum(dice, 3) >= 3)
                result += 300;


            return result;
        }

        private static int CountNum(int[] dice, int num)
        {
            return Array.FindAll(dice, x => x == num).Count();
        }
    }
}
