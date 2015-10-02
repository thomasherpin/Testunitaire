using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testchmod
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testchmod2()
        {
            //test chmod 2 (lettre)
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.chmod("testfalse"));
        }
    }
}
