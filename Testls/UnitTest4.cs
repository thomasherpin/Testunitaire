using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testls
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Testls4()
        {
            //test ls 4
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.createNewFile("toto");
            filecurrent = filecurrent.cd("toto");
            //un ls dans un fichier renvoie un consolewriteline et un null
            Assert.AreEqual(null, filecurrent.ls());
        }
        [TestMethod]
        public void Testls5()
        {
            //test ls 5
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("toto");
            filecurrent = filecurrent.cd("toto");
            filecurrent.chmod("7");
            filecurrent.createNewFile("tata");
            Assert.AreEqual(1, C.ls().Count);
        }
        [TestMethod]
        public void Testls6()
        {
            //test ls 6
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("toto");
            filecurrent.createNewFile("tata");
            Assert.AreEqual(2, C.ls().Count);
        }
    }
}
