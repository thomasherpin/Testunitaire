using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testsearch
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testsearch1()
        {
            //test search 1
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("titi");
            filecurrent = filecurrent.cd("titi");
            filecurrent.chmod("7");
            filecurrent.mkdir("tata");
            filecurrent.createNewFile("titi");
            filecurrent = filecurrent.cd("tata");
            filecurrent.chmod("7");
            filecurrent.createNewFile("titi");
            Assert.AreEqual(3, C.search("titi").Count);
        }
        [TestMethod]
        public void Testsearch1_2()
        {
            //test search 1.2
            Fichier C = new Fichier("C:", null);
            Fichier filecurrent = C;
            Assert.AreEqual(null, C.search("toto"));

        }
        [TestMethod]
        public void Testsearch1_3()
        {
            //test search 1.3
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("titi");
            filecurrent = filecurrent.cd("titi");
            filecurrent.chmod("7");
            filecurrent.mkdir("tata");
            filecurrent.createNewFile("titi");
            filecurrent = filecurrent.cd("tata");
            filecurrent.chmod("7");
            filecurrent.createNewFile("titi");
            filecurrent = filecurrent.getParent();
            filecurrent.chmod("1");
            //getparent non possible sur ca, test supplémentaire
            Assert.AreEqual(null, filecurrent.getParent());
            C.chmod("1");
            Assert.AreEqual(0, C.search("titi").Count);
            //renvoie une liste de fichier vide si non droit => =0
        }
        [TestMethod]
        public void Testsearch1_4()
        {
            //test search 1.4
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("titi");
            filecurrent = filecurrent.cd("titi");
            filecurrent.chmod("7");
            filecurrent.mkdir("tata");
            filecurrent.createNewFile("titi");
            filecurrent = filecurrent.cd("tata");
            filecurrent.chmod("7");
            filecurrent.createNewFile("titi");
            filecurrent = filecurrent.getParent();
            filecurrent.chmod("1");
            C.chmod("7");
            Assert.AreEqual(1, C.search("titi").Count);
        }
    }
}
