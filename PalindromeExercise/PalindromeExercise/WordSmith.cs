using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str1)
        {

            return (new string(str1.ToCharArray().Reverse().ToArray()).Replace(" ", "").ToLower() == (str1.Replace(" ", "").ToLower()) ? true : false);
            //bool isIt = new string(str1.ToCharArray().Reverse().ToArray()).ToLower() == (str1.ToLower());
            //return isIt;

            //char[] strArray = str1.ToCharArray();
            //Array.Reverse(strArray);
            //string revStr = new string(strArray).ToLower();
            //bool isIt = (str1.ToLower() == revStr);
            //return isIt;
        }
    }
}
