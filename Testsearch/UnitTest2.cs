using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testsearch
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testsearch2()
        {
            //test search 2
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("titi");
            Assert.AreEqual(1, C.search("titi").Count);
        }
        [TestMethod]
        public void Testsearch2_1()
        {
            //test search 2
            Repertoire C = new Repertoire("C:", null);
            Fichier filecurrent = C;
            filecurrent.chmod("7");
            filecurrent.mkdir("titi");
            Assert.AreEqual(0, C.search("tata").Count);
        }
    }
}
