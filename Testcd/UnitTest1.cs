using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testcd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test cd 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.AreEqual(C, fileCurrent.cd("toto"));
        }
    }
}
