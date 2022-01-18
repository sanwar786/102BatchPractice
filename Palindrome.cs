using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorldProject102
{
    internal class Palindrome
    {
            ////Get the number from user
           //Hold the number in temporary variable
          ////Reverse the number
         //Compare the temporary number with reversed number
        ////If both numbers are same, print palindrome number
       //Else print not palindrome number
        public static void findPalindrome()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)

            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }

            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }
}
