using System;
namespace Palindrome
{
    class Palindrome
    {
        static void Main()
        {
            Console.WriteLine("Enter any word/phrase to determine whether or not it is a palindrome");
            string s = Console.ReadLine();
            string s1 = s.ToLower();
            string s2 = null; 
            string s3 = null;
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s1[i] >= 97 && (int)s1[i] <= 122)
                {
                    s2 += s1[i];
                }
            }
            Console.WriteLine(s2);
            int o = s2.Length - 1;
            for (int i = 0; i < s2.Length; i++)
            {
                int j = o - i;
                s3 += s2[j];
            }
            if (s3 == s2)
            {
                Console.WriteLine("{0} is a palindrome!", s);
            }
            else
            {
                Console.WriteLine("'{0}' is not a palindrome!", s);
            }
            Console.ReadKey();
        }
    }
}