using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Check c = new Check();
            int a=c.Add();
            Assert.AreEqual(10,a);
            int x = c.Sub();
            Assert.IsNotNull(x);
        }
         [TestMethod]
        public void TestMethod2()
        {
            Check m = new Check();
           int z= m.Sub();
            int k = m.Multiply();
            Assert.AreEqual(2,z);
            Assert.IsTrue(k>12);
        }
        [TestMethod ]
        public void TestMethod3()
        {
            Check n = new Check();
            bool r = n.Div();
            Assert.IsTrue(r==true);
        }
    }
}
