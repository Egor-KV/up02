using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassLibrary.Tests1
{
    [TestClass]
    public class LearnClassTest1
    {
        [TestMethod]
        public void Test_TimeInSecunds()
        {
            //arrange
            int a = 2;
            int b = 3;
            int expected = 7380;

            //act
            LearnClass c = new LearnClass();
            int actual = c.TimeInSecunds(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_GetHour()
        {
            //arrange
            int h = 11;
            int min = 50;
            int sec = h * 3600 + min * 60;
            int dur = 2400;

            sec += dur;

            int expectedH = 12;

            //act
            LearnClass c = new LearnClass();
            int actualH = c.GetHour(sec);

            //assert
            Assert.AreEqual(expectedH, actualH);
        }

        [TestMethod]
        public void Test_GeMinuts()
        {
            //arrange
            int h = 11;
            int min = 50;
            int sec = h * 3600 + min * 60;
            int dur = 2400;

            sec += dur;
            int expectedMin = 30;

            //act
            LearnClass c = new LearnClass();
            int actualMin = c.GetMin(sec);

            //assert
            Assert.AreEqual(expectedMin, actualMin);
        }
    }
}
