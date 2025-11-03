using Xunit;
using ValidateTheNameModelBinding.Models;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Firstname_ValidName_ShouldSetValue()
        {
            // Arrange
            string validName = "Anne-Marie";

            // Act
            var firstname = new Firstname(validName);

            // Assert
            Assert.Equal(validName, firstname.Value);
        }

        [Fact]
        public void Lastname_ValidName_ShouldSetValue()
        {
            // Arrange
            string validName = "O'Connor";

            // Act
            var lastname = new Lastname(validName);

            // Assert
            Assert.Equal(validName, lastname.Value);
        }

        [Theory]
        [InlineData("")]           // empty string
        [InlineData(" ")]          // just space
        [InlineData("123")]        // numbers
        [InlineData("John!")]      // special char
        public void Firstname_InvalidName_ShouldThrow(string invalidName)
        {
            Assert.Throws<ArgumentException>(() => new Firstname(invalidName));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("123")]
        [InlineData("Doe@")]
        public void Lastname_InvalidName_ShouldThrow(string invalidName)
        {
            Assert.Throws<ArgumentException>(() => new Lastname(invalidName));
        }
    }
}