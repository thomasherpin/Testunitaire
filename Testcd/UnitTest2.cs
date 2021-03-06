﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testcd
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testcd2()
        {
            //test cd 2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            fileCurrent = fileCurrent.cd("toto");
            Assert.AreEqual(C.fichieR[0], fileCurrent);
        }
    }
}
