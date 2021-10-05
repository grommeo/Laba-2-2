using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаба_2_2_Сsh;
using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_2_2_Сsh.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void DoliTest1()
        {
            string pr = "Привет 21344";

            var Out = Logic.Doli(pr);

            Assert.AreEqual("Букв: 6\nСимволов: 12\nДоля: 50%", Out);
        }
        [TestMethod()]
        public void DoliTest2()
        {
            string pr = "2134324";

            var Out = Logic.Doli(pr);

            Assert.AreEqual("Букв: 0\nСимволов: 7\nДоля: 0%", Out);
        }
        [TestMethod()]
        public void DoliTest3()
        {
            string pr = "Привет";

            var Out = Logic.Doli(pr);

            Assert.AreEqual("Букв: 6\nСимволов: 6\nДоля: 100%", Out);
        }
        [TestMethod()]
        public void DoliTest4()
        {
            string pr = "м        м";

            var Out = Logic.Doli(pr);

            Assert.AreEqual("Букв: 2\nСимволов: 10\nДоля: 20%", Out);
        }
    }
}