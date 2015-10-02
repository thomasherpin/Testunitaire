using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem3
{
    [TestClass]
    public class UnitTest1
    {
        //chmod n'influence pas les méthodes file&directory
        [TestMethod]
        public void Testfiledirectory1()
        {
            //test file&directory 1
            Repertoire C = new Repertoire("C:", null);
            Fichier D = new Fichier("D", C);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.isfile());
        }
        [TestMethod]
        public void Testfiledirectory2()
        {
            //test file&directory 1
            Repertoire C = new Repertoire("C:", null);
            Fichier D = new Fichier("D", C);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.isDirectory());
        }
        [TestMethod]
        public void Testfiledirectory3()
        {
            Repertoire C = new Repertoire("C:", null);
            Fichier D = new Fichier("D", C);
            Assert.IsTrue(D.isfile());
        }
        [TestMethod]
        public void Testfiledirectory4()
        {
            Repertoire C = new Repertoire("C:", null);
            Fichier D = new Fichier("D", C);
            Assert.IsFalse(D.isDirectory());
        }
    }
}
