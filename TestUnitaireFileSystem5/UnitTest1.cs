using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testcreate1()
        {
            //test create 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            Assert.IsTrue(fileCurrent.createNewFile("C2"));
        }
    }
}
