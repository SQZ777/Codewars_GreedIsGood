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
            var kata = new Kata();
            var input = new[] { 2, 3, 4, 6, 2 };
            var actual = kata.Score(input);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_52346_Should_Be_50()
        {
            var kata = new Kata();
            var input = new[] { 5, 2, 3, 4, 6 };
            var actual = kata.Score(input);
            var expected = 50;
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int Score(int[] dice)
        {
            var result = 0;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 5)
                    result++;
            }
            return 50 * result;
        }
    }
}
