using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testcd
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Testcd4()
        {
            //test cd 3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("tata");
            fileCurrent = fileCurrent.cd("tata");
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");
            fileCurrent = fileCurrent.cd("toto");
            Assert.AreEqual(C.fichieR[0], fileCurrent);
        }
    }
}
