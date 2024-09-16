using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using hello_world_actions2;

namespace hello_world_actions2_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            int result = Program.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
