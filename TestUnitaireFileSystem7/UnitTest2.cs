using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem7
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testdelete2()
        {
            //test delete 2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            Assert.IsTrue(fileCurrent.delete("toto"));
        }
    }
}
