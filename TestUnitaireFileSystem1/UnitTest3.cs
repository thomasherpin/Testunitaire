using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testparent3()
        {
            //test parent 3
            Repertoire C = new Repertoire("C:", null);
            Repertoire C2 = new Repertoire("C2", C);
            Fichier fileCurrent = C2;
            fileCurrent.chmod("1");
            Assert.AreEqual(null, fileCurrent.getParent());
        }
        [TestMethod]
        public void Testparent3_1()
        {
            //test parent 3.1
            Repertoire C = new Repertoire("C:", null);
            Fichier C2 = new Fichier("C2", C);
            Fichier fileCurrent = C2;
            fileCurrent.chmod("1");
            Assert.AreEqual(null, fileCurrent.getParent());
        }
    }
}
