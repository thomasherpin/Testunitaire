using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem5
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testcreate3()
        {
            //test create 3
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.createNewFile("C2"));
            fileCurrent.chmod("7");
            Assert.IsFalse(fileCurrent.createNewFile("C2"));
        }
    }
}
