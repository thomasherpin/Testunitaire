using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testdelete1()
        {
            //test delete 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            Assert.IsFalse(fileCurrent.delete("toto"));
        }
    }
}
