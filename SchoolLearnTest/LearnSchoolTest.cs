using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
using WindowsFormsApp1.utils.time;

namespace SchoolLearnTest
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

        [TestMethod]
        public void testConvertSecondsIntoHrs()
        {
            int twoHours = 2;

            Assert.AreEqual(twoHours, TimeConverter.convertSecondsIntoHrs(7200));

            int fourHours = 4;

            Assert.AreEqual(fourHours, TimeConverter.convertSecondsIntoHrs(14400));
        }

        [TestMethod]
        public void testConvertSecondsIntoMins()
        {
            int twoMins = 2;

            Assert.AreEqual(twoMins, TimeConverter.convertSecondsIntoMins(120));

            int fourMins = 4;

            Assert.AreEqual(fourMins, TimeConverter.convertSecondsIntoMins(240));
        }

    }
}
