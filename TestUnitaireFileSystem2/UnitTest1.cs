using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testname1()
        {
            //test name 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.AreEqual(C.Nom, fileCurrent.getName());
        }
        [TestMethod]
        public void Testname1_1()
        {
            //test name 1.1
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            Assert.AreEqual(C.Nom, fileCurrent.getName());
        }
    }
}
