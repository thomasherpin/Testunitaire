using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem5
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test create 3
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            Assert.IsFalse(fileCurrent.createNewFile("C2"));
        }
    }
}
