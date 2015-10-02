using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testls
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testls1()
        {
            //test ls 1
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            Assert.AreEqual(0, C.ls().Count);
        }
        [TestMethod]
        public void Testls1_1()
        {
            //test ls 1.1
            Fichier C = new Fichier("C:", null);
            Fichier filecurrent = C;
            Assert.AreEqual(null, C.ls());
        }
    }
}
