
using System;
using Xunit;

namespace AP02023_hw00_Welcome.Tests
{
    public class AP02023_hw00_Welcome
    {
        [Fact]
        [Trait("TestGroup", "Adder")]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = Program.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        [Trait("TestGroup", "HelloWorld")]
        public void GetMessage_ShouldReturnHelloWorld()
        {
            // Arrange

            // Act
            string message = Program.GetMessage();

            // Assert

            Assert.Equal("Hello World!", message);
        }
    }
}

