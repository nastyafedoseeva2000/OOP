using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 2,9,5,2,5,7 }, 5)]
        [TestCase(new int[] { 1,3,5,7,9,11 }, 6)]
        [TestCase(new int[] { 5,8,5 }, 6)]
        [TestCase(new int[] { -5,5 }, 0)]
        [TestCase(new int[] { 11,44,66,2 }, 30.75)]
        [TestCase(new int[] { 7,0 }, 3.5)]
        [TestCase(new int[] { 3,0,9,66 }, 19.5)]
        [TestCase(new int[] { -32, -45, -56, -67 }, -50)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1)]
        public void Test1(int[] a, double expectedResult)
        {
            Assert.AreEqual(expectedResult, ËÐ_3.Program.myDelegate.Invoke(a));
        }

        [TestCase(4, 2, "-", ExpectedResult = 2)]
        [TestCase(1, 3, "+", ExpectedResult = 4)]
        [TestCase(7, 2, "*", ExpectedResult = double.MinValue + 1)]
        [TestCase(0, 1, "-", ExpectedResult = -1)]
        [TestCase(0, 0, "+", ExpectedResult = 0)]
        [TestCase(44, 4, "-", ExpectedResult = 40)]
        [TestCase(60, -80, "-", ExpectedResult = 140)]
        [TestCase(-440, -60, "+", ExpectedResult = -500)]
        [TestCase(12, 14, "-", ExpectedResult = -2)]
        [TestCase(1000, 0, "+", ExpectedResult = 1000)]
        public double Task2Test(double x, double y, string operatorr)
        {
            return ËÐ_3.Program.myDelegatenew.Invoke(x, y, operatorr);
        }
    }
}