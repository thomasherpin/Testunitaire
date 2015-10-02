using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testls
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testls2()
        {
            //test ls 2
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("toto");
            Assert.AreEqual(1, C.ls().Count);
        }
    }
}
