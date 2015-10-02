using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testls
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testls3()
        {
            //test ls 3
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("toto");
            filecurrent = filecurrent.cd("toto");
            Assert.AreEqual(0, filecurrent.ls().Count);
        }
    }
}
