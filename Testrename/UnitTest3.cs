using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testrename
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testrename3()
        {
            //test rename 3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent.mkdir("tata");
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename3_1()
        {
            //test rename 3.1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent.createNewFile("tata");
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename3_2()
        {
            //test rename 3.2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");
            fileCurrent.mkdir("tata");
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename3_3()
        {
            //test rename 3.3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");
            fileCurrent.createNewFile("tata");
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
    }
}
