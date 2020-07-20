using System;

namespace Palindrome.Domain
{
    public class Class1
    {
        // Function to check if something is a palindrome
        public static bool IsPalindrome(string value)
        {
           int min = 0;
           int max = value.Length - 1;

           char a = value[min];
           char b = value[max];

           while (true)
           {
              if (min > max)
              {
                return true;
              }

              // Check if first and last character of string are equal
              if (char.ToLower(a) != char.ToLower(b))
              {
                  return false;
              }
              min++;
              max--;

           }
        }

        static void Main()
        {
          string[] array = {"civic'", "level", "racecar"};

          foreach (string value in array)
          {
              Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
          }
        }
    }
}
