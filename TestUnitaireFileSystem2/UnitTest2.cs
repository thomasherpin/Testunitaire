using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;
    
namespace TestUnitaireFileSystem2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testname2()
        {
            //test name 2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("1");
            Assert.AreEqual(null, fileCurrent.getName());
        }
        [TestMethod]
        public void Testname2_1()
        {
            //test name 2.1
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("1");
            Assert.AreEqual(null, fileCurrent.getName());
        }
    }
}
