﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testrename
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testrename2()
        {
            //test rename 2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            Assert.IsTrue(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename2_1()
        {
            //test rename 2.1
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");//le répertoire ne se créé pas (dans un fichier)
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename2_3()
        {
            //test rename 2.3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");
            Assert.IsTrue(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename2_4()
        {
            //test rename 2.4
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");//le fichier ne se créé pas (dans un fichier)
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
    }
}
