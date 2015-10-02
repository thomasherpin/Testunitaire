using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testchmod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testchmod1()
        {
            //test chmod 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.chmod("1"));
        }
        [TestMethod]
        public void Testchmod2()
        {
            //test chmod 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.chmod("2"));
        }
        [TestMethod]
        public void Testchmod3()
        {
            //test chmod 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.chmod("3"));
        }
        [TestMethod]
        public void Testchmod4()
        {
            //test chmod 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.chmod("4"));
        }
        [TestMethod]
        public void Testchmod5()
        {
            //test chmod 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.chmod("5"));
        }
        [TestMethod]
        public void Testchmod6()
        {
            //test chmod 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.chmod("6"));
        }
        [TestMethod]
        public void Testchmod7()
        {
            //test chmod 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsTrue(fileCurrent.chmod("7"));
        }
    }
}
