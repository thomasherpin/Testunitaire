using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem6
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test mkdir 3
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            Assert.IsFalse(fileCurrent.mkdir("C2"));
        }
    }
}
