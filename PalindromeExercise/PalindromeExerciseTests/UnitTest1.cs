using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kakak", true)]
        [InlineData("racecar", true)]

        public void Test1(string word, bool expected)
        {
            var pal = new WordSmith();

            var actual = pal.IsAPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
