using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem6
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testmkdir3()
        {
            //test mkdir 3
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.mkdir("C2"));
        }
        [TestMethod]
        public void Testmkdir3_3()
        {
            //test mkdir 3_3
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            Assert.IsFalse(fileCurrent.mkdir("C2"));
        }
    }
}
