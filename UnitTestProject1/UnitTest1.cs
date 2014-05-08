using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTambah()
        {
            MainWindow calc = new MainWindow();
            double op1 = 2;
            double op2 = 7;
            double expect = 9;
            double actual = calc.tambah(op1, op2);

            Assert.AreEqual(expect, actual, "true");
        }
        [TestMethod]
        public void TestMethodKurang()
        {
            MainWindow calc = new MainWindow();
            double op1 = 9;
            double op2 = 12;
            double expect = -3;
            double actual = calc.kurang(op1, op2);

            Assert.AreEqual(expect, actual, "true");

        }
        [TestMethod]
        public void TestMethodKali()
        {
            MainWindow calc = new MainWindow();
            double op1 = 9;
            double op2 = 9;
            double expect = 81;
            double actual = calc.kali(op1, op2);

            Assert.AreEqual(expect, actual, "true");
        }
        [TestMethod]
        public void TestMethodBagi()
        {
            MainWindow calc = new MainWindow();
            double op1 = 6;
            double op2 = 3;
            double expect = 2;
            double actual = calc.bagi(op1, op2);

            Assert.AreEqual(expect, actual, "true");
        }
    }
}
