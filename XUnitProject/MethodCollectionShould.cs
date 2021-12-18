using System;
using Xunit;
using ClassLibraryProject;

namespace ClassLibraryProject.Test
{
    public class MethodCollectionShould
    {
        [Theory]
        [InlineData(4, false)]
        [InlineData(73, true)]
        [InlineData(7919, true)]
        [InlineData(7921, false)]
        [InlineData(560239, true)]
        [InlineData(678321, false)]
        [InlineData(1088123, true)]
        public void TestIsPrimeNumber(int number, bool fact)
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
        public void TestWordCount(string sentence, int fact)
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
        public void TestIsOdd(int number, bool boolean)
        {
            // Arrange

            // Act
            bool odd = MethodCollection.IsOdd(number);

            //Assert
            Assert.Equal(boolean, odd);
        }
    }
}
