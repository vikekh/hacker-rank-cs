using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vikekh.HackerRank.Challenges.SimpleTextEditor.Test
{
    [TestClass]
    public class EditorTest
    {
        [TestMethod]
        public void OperationTest()
        {
            var editor = new Editor("");

            editor.Operation(1, "abc");

            Assert.AreEqual("c", editor.Operation(3, "3"));

            editor.Operation(2, "3");
            editor.Operation(1, "xy");

            Assert.AreEqual("y", editor.Operation(3, "2"));

            editor.Operation(4);
            editor.Operation(4);

            Assert.AreEqual("a", editor.Operation(3, "1"));
        }
    }
}
