using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TimeInSecunds()
        {
            // подготовка
            int a = 2;
            int b = 3;
            int expected = 7380;

            // выполнение
            Record recordForm = new Record();


            int result = recordForm.TimeInSeconds(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}
