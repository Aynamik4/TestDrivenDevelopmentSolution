using System;
using Xunit;
using ClassLibraryProject.Domain;

namespace XUnitProject
{
    public class UnitTest
    {
        [Theory]
        [InlineData(4, false)]
        [InlineData(73, true)]
        [InlineData(7919, true)]
        [InlineData(7921, false)]
        [InlineData(560239, true)]
        [InlineData(678321, false)]
        [InlineData(1088123, true)]
        public void IsPrimeNumberTest(int number, bool fact)
        {
            // Arrange

            // Act
            bool isPrimeNumber = MethodCollection.IsPrimeNumber(number);

            // Assert
            Assert.Equal(fact, isPrimeNumber);
        }

        [Theory]
        [InlineData("Academy", 1)]
        [InlineData("Acdemic Work", 2)]
        [InlineData("Acdemic.Work.AB", 3)]
        [InlineData("Acdemic;Work Academy;Sweden;AB", 5)]
        public void WordCountTest(string sentence, int fact)
        {
            // Arrange

            // Act
            int count = MethodCollection.WordCount(sentence);

            //Assert
            Assert.Equal(fact, count);
        }

        [Theory]
        [InlineData(2798, false)]
        [InlineData(1399, true)]
        public void IsOddTest(int number, bool boolean)
        {
            // Arrange

            // Act
            bool odd = MethodCollection.IsOdd(number);

            //Assert
            Assert.Equal(boolean, odd);
        }

        [Fact]
        public void PersonTest1()
        {
            // Arrange
            Person p = new Person("Anna", "Andersson", true, Continent.Antarctica);
            //                    first name, last name, is system deveoper, where from

            // Act
            string presentation = p.GetPresentation();

            //Assert
            Assert.Equal("Anna Andersson is from the continent of Antarctica and is a system developer.", presentation);
        }

        [Fact]
        public void PersonTest2()
        {
            // Arrange
            Person p = new Person("Bertil", "Bertilsson", false, Continent.South_America);
            //                    first name, last name, is system deveoper, where from

            // Act
            string presentation = p.GetPresentation();

            //Assert
            Assert.Equal("Bertil Bertilsson is from the continent of South_America and isn't a system developer.", presentation);
        }
    }
}
