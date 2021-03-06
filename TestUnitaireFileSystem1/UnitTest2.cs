﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace TestUnitaireFileSystem1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testparent2()
        {
            //test parent 2
            Repertoire C = new Repertoire("C:", null);
            Repertoire C2 = new Repertoire("C2", C);
            Fichier fileCurrent = C2;
            Assert.AreEqual(C, fileCurrent.getParent());
        }
        [TestMethod]
        public void Testparent2_1()
        {
            //test parent 2.1
            Repertoire C = new Repertoire("C:", null);
            Fichier C2 = new Fichier("C2", C);
            Fichier fileCurrent = C2;
            Assert.AreEqual(C, fileCurrent.getParent());
        }
    }
}
