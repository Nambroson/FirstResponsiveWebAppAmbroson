using System;
using Xunit;
using FirstResponsiveWebAppAmbroson.Models;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AgeByEndOfYear()
        {

            //Arrange
            int birthYear = 1987;

            int expected = 34;
            int actual;

            //act
            FirstResponsiveWebAppModel nick = new FirstResponsiveWebAppModel
            {
                BirthYear = birthYear
            };
            actual = nick.AgeThisYear();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
