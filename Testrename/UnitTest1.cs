using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testrename
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test rename 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.renameTo("C:", "C"));
        }
    }
}
