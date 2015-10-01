using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testcd
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test cd 2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            Fichier nextfileCurrent = new Repertoire ("toto", C);
            Assert.AreEqual(nextfileCurrent, fileCurrent.cd("toto"));
        }
    }
}
