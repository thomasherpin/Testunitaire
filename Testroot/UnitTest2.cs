using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testroot
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test root 2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent.cd("toto");
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("tata");
            fileCurrent.cd("tata");
            Assert.AreEqual("toto", fileCurrent.getRoot());
        }
    }
}
