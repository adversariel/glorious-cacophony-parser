using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cacophony;

namespace Testing
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestPosToFreq()
        {
            int c = Noises.PositionToFreq(40);

            Assert.AreEqual(261, c);
        }
    }
}
