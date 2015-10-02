using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testroot
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testroot3()
        {
            //test root 3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent = fileCurrent.cd("toto");
            Assert.AreEqual("Vous êtes déjà dans un fichier racine", fileCurrent.getRoot());
        }
        [TestMethod]
        public void Testroot3_1()
        {
            //test root 3.1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent = fileCurrent.cd("toto");
            fileCurrent.chmod("1");
            Assert.AreEqual(null, fileCurrent.getRoot());
        }
    }
}
