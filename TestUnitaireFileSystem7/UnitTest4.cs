using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem7
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Testdelete4()
        {
            //test delete 4
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            Assert.IsFalse(fileCurrent.delete("tata"));
        }
    }
}
