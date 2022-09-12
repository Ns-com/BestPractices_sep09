using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "actor";
            //Act
            var result = currentActor.GetOccupation();
            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestParamterizedCons()
        {
            //Arrange
            var currentActor = new Actor("harry");
            var expected = "harry";
            //Act
            //calling the propery ActorName;
            string result = currentActor.ActorName;
            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestSettingObjectProperty()
        {
            //Arrange
            var currentActor = new Actor();
            currentActor.ActorName = "harry";
            var expected = "harry";
            //Act
            //calling the propery ActorName;
            string result = currentActor.ActorName;
            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void TestActorBook()
        {
            //assign
            var currentActor = new Actor("ram");
            var expected = "Actor ram is booked. Booking can change";
            //act
            var result = currentActor.BookActor();
            //assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestActorBookDate()
        {
            //assign
            var currentActor = new Actor("ram");
            var expected = "Actor ram is booked. Booking can change"+DateTime.Today.ToShortDateString();

            //act
            var result = currentActor.BookActor(DateTime.Today.ToShortDateString());
            //assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestFormattingOnSetterForActorBook()
        {
            //assign
            var currentActor = new Actor("ram  ");
            var expected = "Actor ram is booked. Booking can change";
            //act
            var result = currentActor.BookActor();
            //assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            //assign
            var currentActor = new Actor { ActorName = "ramu" };
            var expected = "Regular actor";
            //act
            var result = currentActor.ActorDescription; 
            //assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestAutoPropInitActorAge()
        {
            //assign
            var currentActor = new Actor { ActorName = "ramu", ActorAge=46 };
            var expected = 46;
            //act
            var result = currentActor.ActorAge;
            //assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void TestGetAgency()
        {
            //assign
            var currentActor = new Actor ();
            var expected = "Prestige Talent";
            //act
            var result = currentActor.GetAgencyName();
            //assert
            Assert.AreEqual(result, expected);
        }
    }
}
