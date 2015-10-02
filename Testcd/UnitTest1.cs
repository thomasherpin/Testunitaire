using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testcd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testcd1()
        {
            //test cd 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent = fileCurrent.cd("toto");
            Assert.AreEqual(C, fileCurrent);
        }
    }
}
