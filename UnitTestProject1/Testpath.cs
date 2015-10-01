using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class Testpath
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test path 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.AreEqual("C:", fileCurrent.getPath());
        }
    }
}
