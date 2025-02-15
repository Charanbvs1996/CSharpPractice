using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpBasicsPractice
{
    internal class AddTwoNumbers
    {
        public int Num1, Num2;
        public AddTwoNumbers() { }
        public AddTwoNumbers(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public int AddNumbers() => Num1 + Num2;  //This syntax is called a "Expression-bodied method" in C#.
        public bool isPalindrome(string inputVal)
        {
            string? outputval = new string(inputVal.Reverse().ToArray());
            //inputVal.Reverse() returns an IEnumerable<char>, not a string..ToString() on an IEnumerable<char> does not convert it to a string.
            //Instead, you need to convert it to an array first and then create a string.
            if (!string.IsNullOrWhiteSpace(outputval))
            {
                if (outputval.Equals(inputVal)) return true;
            }
            return false;
        }
    }
}