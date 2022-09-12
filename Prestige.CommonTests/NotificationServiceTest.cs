using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Common;
using System;

namespace Prestige.CommonTests
{
    [TestClass]
    public class NotificationServiceTest
    {
        [TestMethod]
        public void NotifyTalentTest()
        {
            //arrange
            var expect = "Talent:ram";
            //act
            var actual = NotificationService.NotifyTalent("ram");
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}
