using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testcd
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testcd3()
        {
            //test cd 3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");
            fileCurrent = fileCurrent.cd("toto");
            Assert.AreEqual(C.fichieR[0], fileCurrent);
        }
    }
}
