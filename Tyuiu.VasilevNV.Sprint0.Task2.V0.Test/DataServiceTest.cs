using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VasilevNV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VasilevNV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Коля";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Коля", res);
        }
    }
}
