using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test parent 2
            Repertoire C = new Repertoire("C:", null);
            Repertoire C2 = new Repertoire("C2", C);
            Fichier fileCurrent = C2;
            Assert.AreEqual(C, fileCurrent.getParent());
        }
    }
}
