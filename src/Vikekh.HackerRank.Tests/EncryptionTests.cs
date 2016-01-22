using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vikekh.HackerRank.Challenges.Encryption;

namespace Vikekh.HackerRank.Challenges.Tests
{
    [TestClass]
    public class EncryptionTests
    {
        [TestMethod]
        public void Encrypt_HaveANiceDay()
        {
            Assert.AreEqual("hae and via ecy", Solution.Encrypt("haveaniceday"));
        }

        [TestMethod]
        public void Encrypt_FeedTheDog()
        {
            Assert.AreEqual("fto ehg ee dd", Solution.Encrypt("feedthedog"));
        }

        [TestMethod]
        public void Encrypt_ChillOut()
        {
            Assert.AreEqual("clu hlt io", Solution.Encrypt("chillout"));
        }
    }
}
