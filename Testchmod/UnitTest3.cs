using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testchmod
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Testchmod3()
        {
            //test chmod 3 (chiffre)
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.chmod("0"));
        }
        [TestMethod]
        public void Testchmod4()
        {
            //test chmod 3 (chiffre)
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.chmod("8"));
        }
        [TestMethod]
        public void Testchmod5()
        {
            //test chmod 3 (chiffre)
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.chmod("-1"));
        }
    }
}
