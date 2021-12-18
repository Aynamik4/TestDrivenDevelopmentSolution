using Xunit;
using System;

namespace ClassLibraryProject.Test
{
    public class PersonShould
    {
        [Fact]
        public void BeSystemDeveloper()
        {
            // Arrange
            Person p = new Person("Anders", "Hejlsberg", true, Continent.Antarctica);
            //                    first name, last name, is system deveoper, where from

            bool isSystemDeveloper = p.IsSystemDeveloper;

            //Assert
            Assert.True(isSystemDeveloper);
        }

        [Theory]
        [InlineData("Ada", "Lovelace", "lace")]
        [InlineData("Anders", "Hejlsberg", "sberg")]
        [InlineData("Alan", "Turing", "ring")]
        public void HaveALastNameThatEndsWith(string firstName, string lastName, string expectedEndString)
        {
            // Arrange
            Person p = new Person(firstName, lastName, true, Continent.Antarctica);
            //                    first name, last name, is system deveoper, where from

            string fullName = p.FullName;

            //Assert
            Assert.EndsWith(expectedEndString, fullName); // FullName ex. "Ada Lovelace
        }

        [Fact]
        public void StartWithDefaultHealth()
        {
            // Arrange
            Person person = new Person("Håkan", "Johansson", true, Continent.Europe);

            int health = person.Health;

            // Assert
            Assert.Equal(100, health);
        }

        [Fact]
        public void BePresentedAsAnna()
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
        public void BePresentedAsBertil()
        {
            // Arrange
            Person p = new Person("Bertil", "Bertilsson", false, Continent.South_America);
            //                    first name, last name, is system deveoper, where from

            // Act
            string presentation = p.GetPresentation();

            //Assert
            Assert.Equal("Bertil Bertilsson is from the continent of South_America and isn't a system developer.", presentation);
        }

        [Theory]
        [InlineData("Cecilia", "Sivsdotter")]
        [InlineData("", "")]
        [InlineData("Bo", "Öman")]
        public void ComputeLengthOfFirstNameAndLastName(string firstName, string lastName)
        {
            // Arrange
            int lengthOfFirstNameAndLastName = firstName.Length + lastName.Length;
            Person p = new Person(firstName, lastName, false, Continent.Europe);
            //                    first name, last name, is system deveoper, where from

            // Act
            int numCharacters = p.LengthOfFirstNameAndLastName;

            //Assert
            Assert.Equal(lengthOfFirstNameAndLastName, numCharacters);
        }

        [Fact]
        public void HaveAWristWatchInInventory()
        {
            // Arrange
            Person p = new Person("Jane", "Doe", false, Continent.North_America);
            //                    first name, last name, is system deveoper, where from

            //Assert
            Assert.Contains<string>("Wrist Watch", p.Inventory);
        }

        [Fact]
        public void ThrowArgumentOutOfRangeException()
        {
            // Arrange
            Person p = new Person("Jane", "Doe", false, Continent.North_America);
            //                    first name, last name, is system deveoper, where from

            // Setting the Health property on a Person instance to a value outside the range of 0 to 100
            // should throw an ArgumentOutOfRangeException.

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>("Health", () => p.Health = 101);
        }
    }
}
