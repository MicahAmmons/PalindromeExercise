using System;
using System.Drawing;
using System.Reflection.Emit;
using Xunit;
using PalindromeExerciseTests;
using PalindromeExercise;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Anna", true)]
        [InlineData("Rotator", true)]
        [InlineData("Rotor", true)]
        [InlineData("Sagas", true)]
        [InlineData("Solos", true)]
        [InlineData("Stats", true)]
        [InlineData("Tenet", true)]
        [InlineData("Wow", true)]
        [InlineData("Ploop", false)]
        [InlineData("Plop", false)]
        [InlineData("Was it a car or a cat I saw", true)]
        [InlineData("Never odd or even", true)]
        [InlineData("Duck goes Quack", false)]
        public void PalindromeTest(string str1, bool expected)
        {
            //Arrange
            WordSmith instance = new WordSmith();
            //Act
            var actual = instance.IsAPalindrome(str1);
            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}


//Let’s create a Unit Test for a method that tells us if a word is a Palindrome. In our unit test we will need to Arrange, Act, and Assert and follow the Red, Green, Refactor process
//Fork and clone the following:
//Palindrome Exercise

//Make sure the PalindromeExerciseTests project file has PalindromeExercise added as a reference.

//→ Right click Dependencies in PalindromeExerciseTests to check and add a Project Reference if need be

//Create a class named WordSmith in your PalindromeExercise project file. This is where you will eventually create your IsAPalindrome() method

//In your WordSmith class, you will create a method (IsAPalindrome) that will take a parameter of type string and return a value of type bool. If the given input is a palindrome – return true, else return false. You will finish this method after you write your tests.

//Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file

//In UnitTest1.cs, remove the Fact portion and replace it with:

//[Theory]
//[InlineData()] // ← you will need to put some test data and expected result here.  

//// For example [InlineData(“racecar”, true)]
//Finish the test with Arrange, Act, Assert and make your IsAPalindrome method pass the tests
//Once finished, save, commit, and push back to Github
