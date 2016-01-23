using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vikekh.HackerRank.Challenges.TwoStrings;

namespace Vikekh.HackerRank.Challenges.TwoStrings.Test
{
    [TestClass]
    public class TwoStringsTests
    {
        [TestMethod]
        public void HasCommonSubstring_HelloWorld()
        {
            Assert.IsTrue(Solution.HasCommonSubstring("hello", "world"));
        }

        [TestMethod]
        public void HasCommonSubstring_HelloWorldReversed()
        {
            Assert.IsTrue(Solution.HasCommonSubstring("world", "hello"));
        }

        [TestMethod]
        public void HasCommonSubstring_HiWorld()
        {
            Assert.IsFalse(Solution.HasCommonSubstring("hi", "world"));
        }

        [TestMethod]
        public void HasCommonSubstring_HiWorldReversed()
        {
            Assert.IsFalse(Solution.HasCommonSubstring("world", "hi"));
        }
    }
}
