using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class Testpath
    {
        [TestMethod]
        public void Testpath1()
        {
            //test path 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.AreEqual("C:", fileCurrent.getPath());
        }
        [TestMethod]
        public void Testpath1_1()
        {
            //test path 1.1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent = fileCurrent.cd("toto");
            Assert.AreEqual("C:\\toto", fileCurrent.getPath());
        }
        [TestMethod]
        public void Testpath1_2()
        {
            //test path 1.2, donne la même chose que le testpath1_1, pas de diff file/directory
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");
            fileCurrent = fileCurrent.cd("toto");
            Assert.AreEqual("C:\\toto", fileCurrent.getPath());
        }
    }
}
