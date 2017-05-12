using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Machine
{
    [TestFixture]
    class TestClass
    {
        
        [TestCase]
        public void TestCase_1()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(1, 2, "Coca Cola Classic", 10));// Not enough money
        }

        [TestCase]
        public void TestCase_2()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(2, 2, "Coca Cola Classic", 10));// Success
        }

        [TestCase]
        public void TestCase_3()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(0, testObj.Calculate(2, 2, "Coca Cola Classic", 0));//there is no product

        }


        [TestCase]
        public void TestCase_4()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(1.5, 2.5, "Sprite", 10));// Not enough money
        }

        [TestCase]
        public void TestCase_5()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(2.5, 2.5, "Sprite", 10));// Success
        }

        [TestCase]
        public void TestCase_6()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(0, testObj.Calculate(2.5, 2.5, "Sprite", 0));//there is no product

        }

        [TestCase]
        public void TestCase_7()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(1, 2, "Fanta", 10));// Not enough money
        }

        [TestCase]
        public void TestCase_8()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(2, 2, "Fanta", 10));// Success
        }

        [TestCase]
        public void TestCase_9()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(0, testObj.Calculate(2, 2, "Fanta", 0));//there is no product

        }


        [TestCase]
        public void TestCase_10()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(2.5, 3.5, "Cappy", 10));// Not enough money
        }

        [TestCase]
        public void TestCase_11()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(3.5, 3.5, "Cappy", 10));// Success
        }

        [TestCase]
        public void TestCase_12()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(0, testObj.Calculate(3.5, 3.5, "Cappy", 0));//there is no product

        }

        [TestCase]
        public void TestCase_13()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(1, 2, "Water", 10));// Not enough money
        }

        [TestCase]
        public void TestCase_14()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(2, 2, "Water", 10));// Success
        }

        [TestCase]
        public void TestCase_15()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(0, testObj.Calculate(2, 2, "Water", 0));//there is no product

        }


        [TestCase]
        public void TestCase_16()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(2, 3, "Fusetea Lemon", 10));// Not enough money
        }

        [TestCase]
        public void TestCase_17()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(9, testObj.Calculate(3, 3, "Fusetea Lemon", 10));// Success
        }

        [TestCase]
        public void TestCase_18()
        {
            Form1 testObj = new Form1();

            Assert.AreEqual(0, testObj.Calculate(3, 3, "Fusetea Lemon", 0));//there is no product

        }
    }
}
