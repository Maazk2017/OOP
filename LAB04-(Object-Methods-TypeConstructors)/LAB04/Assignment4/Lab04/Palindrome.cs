using System;

namespace Lab04
{
    class Palindrome
    {
        public void CheckPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            bool flag = true;

            while (left <= right)
            {
                if (s[left] != s[right])
                {
                    flag = false;
                    break;
                } else
                {
                    left++;
                    right--;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Not a palindrome");
            } else
            {
                Console.WriteLine("Palindrome");
            }
        }
    }
}
