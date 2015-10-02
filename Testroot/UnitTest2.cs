using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testroot
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testroot2()
        {
            //test root 2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent = fileCurrent.cd("toto");
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("tata");
            fileCurrent = fileCurrent.cd("tata");
            Assert.AreEqual("toto", fileCurrent.getRoot());
        }
        [TestMethod]
        public void Testroot2_1()
        {
            //test root 2.1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent = fileCurrent.cd("toto");
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("tata");
            fileCurrent = fileCurrent.cd("tata");
            fileCurrent.chmod("1");
            Assert.AreEqual(null, fileCurrent.getRoot());
        }
    }
}
