using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testroot
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test root 3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            Assert.IsTrue(fileCurrent.mkdir("toto"));
            fileCurrent.cd("toto");
            //Assert.AreEqual("Vous êtes déjà dans un fichier racine", fileCurrent.getRoot());
        }
    }
}
