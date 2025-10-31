using Microsoft.VisualStudio.TestPlatform.TestHost;
using Sticks;
using Xunit;

namespace Sticks.Tests
{
    public class SolutionTests
    {
        // --- Invalid / Edge Inputs ---
        [Theory]
        [InlineData(0, 10, 0)]
        [InlineData(10, 0, 0)]
        [InlineData(-5, 10, 0)]
        [InlineData(10, -3, 0)]
        [InlineData(0, 0, 0)]
        public void Solution_ShouldReturnZero_WhenInputsAreInvalid(int a, int b, int expected)
        {
            int result = Program.Solution(a, b);
            Assert.Equal(expected, result);
        }

        // ---  Equal Inputs ---
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(8, 8, 4)]
        [InlineData(100, 100, 50)]
        [InlineData(9, 9, 4)]
        public void Solution_ShouldReturnHalf_WhenInputsAreEqual(int a, int b, int expected)
        {
            int result = Program.Solution(a, b);
            Assert.Equal(expected, result);
        }

        // --- Valid Inputs ---
        [Theory]
        [InlineData(10, 21, 7)]  
        [InlineData(13, 11, 5)] 
        [InlineData(2, 1, 0)]
        [InlineData(1, 8, 2)]
        [InlineData(6, 15, 5)]   
        [InlineData(25, 40, 13)] 
        [InlineData(50, 50, 25)] 
        [InlineData(7, 30, 7)]   
        [InlineData(12, 9, 4)]   
        [InlineData(100, 10, 25)] 
        public void Solution_ShouldReturnExpectedValue(int a, int b, int expected)
        {
            int result = Program.Solution(a, b);
            Assert.Equal(expected, result);
        }

        // --- Edge Behavior Near Thresholds ---
        [Theory]
        [InlineData(3, 3, 1)] 
        [InlineData(4, 4, 2)] 
        [InlineData(5, 10, 3)] 
        [InlineData(10000000, 20000000, 6666666)] 
        public void Solution_ShouldHandleEdgeAndLargeCases(int a, int b, int expected)
        {
            int result = Program.Solution(a, b);
            Assert.Equal(expected, result);
        }
    }
}