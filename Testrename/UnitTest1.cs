﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystem;

namespace Testrename
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testrename1()
        {
            //test rename 1
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename1_1()
        {
            //test rename 1.1, la même qu'au dessus pour un fichier
            Fichier C = new Fichier("C:", null);
            Fichier fileCurrent = C;
            Assert.IsFalse(fileCurrent.renameTo("toto", "tata"));
        }
        [TestMethod]
        public void Testrename1_2()
        {
            //test rename 1.2
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.mkdir("toto");
            Assert.IsFalse(fileCurrent.renameTo("toto", "toto"));
        }
        [TestMethod]
        public void Testrename1_3()
        {
            //test rename 1.3
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            fileCurrent.chmod("7");
            fileCurrent.createNewFile("toto");
            Assert.IsFalse(fileCurrent.renameTo("toto", "toto"));
        }
    }
}
