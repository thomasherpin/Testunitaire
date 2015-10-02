using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testroot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testroot1()
        {
            //test root 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.AreEqual(null, fileCurrent.getRoot());
        }
    }
}
