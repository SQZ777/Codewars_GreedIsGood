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
            result += Judge50(dice);
            return result;
        }

        private static int Judge50(int[] dice)
        {
            var result = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 5)
                    result++;
            }
            return result * 50;
        }

        
    }
}
