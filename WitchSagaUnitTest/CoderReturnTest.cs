using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WitchSaga;

namespace WitchSagaUnitTest
{
    [TestClass]
    public class CoderReturnTest
    {
        [TestMethod]
        public void avgDeathsTestMethod1()
        {
            //Arrange
            double expected = 4.5;
            List<Person> lst = new List<Person>();
            Person p1 = new Person();
            p1.YearOfDeath = 15;
            p1.Age = 10;
            lst.Add(p1);
            Person p2 = new Person();
            p2.Age = 13; p2.YearOfDeath = 17;
            lst.Add(p2);


            //Act
            double actual = CoderReturn.averageDeathsperYear(lst);

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void avgDeathsTestMethod2()
        {
            //Arrange
            double expected = -1;
            List<Person> lst = new List<Person>();
            Person p1 = new Person();
            p1.YearOfDeath = 12;
            p1.Age = 13;
            lst.Add(p1);
            Person p2 = new Person();
            p2.Age = 13; p2.YearOfDeath = 17;
            lst.Add(p2);


            //Act
            double actual = CoderReturn.averageDeathsperYear(lst);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void avgDeathsTestMethod3()
        {
            //Arrange
            double expected = -1;
            List<Person> lst = new List<Person>();
            Person p1 = new Person();
            p1.YearOfDeath = 12;
            p1.Age = -9;
            lst.Add(p1);
            Person p2 = new Person();
            p2.Age = 13; p2.YearOfDeath = 17;
            lst.Add(p2);


            //Act
            double actual = CoderReturn.averageDeathsperYear(lst);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
