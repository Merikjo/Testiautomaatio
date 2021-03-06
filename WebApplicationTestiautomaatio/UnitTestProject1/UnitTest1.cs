﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationTestiautomaatio.Utilities;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //attribuutti
        public void PäivämääräTestit()
        {
            // kelvollinen päivämäärä
            string syöte = "26.4.2016";
            DateTime tulos = DateParsing.ParseFinnishDate(syöte);
            DateTime odotettu = new DateTime(2016, 4, 26);
            Assert.AreEqual(odotettu, tulos);

            // karkauspäivämäärä
            syöte = "29.2.2016";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = new DateTime(2016, 2, 29);
            Assert.AreEqual(odotettu, tulos);

            // virheellinen syöte
            syöte = "";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            // virheellinen syöte 2
            syöte = null;
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            // virheellinen päivämäärä
            syöte = "4/26/2016";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);
        }
    }
}
