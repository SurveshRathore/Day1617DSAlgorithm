using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1617Algorithm
{
    internal class UC6AnagramDetection
    {
        public void detectAnagram()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the Second string: ");
            string str2 = Console.ReadLine();

            int str1Length = str1.Length;
            int str2Length = str2.Length;

            if (str1Length == str2Length)
            {
                bool anagram = false;
                int j = str2Length - 1;
                for (int i = 0; i < str1Length; i++)
                {
                    if (str1[i] == str2[j])
                    {
                        anagram = true;
                        j--;
                    }
                    else
                    {
                        Console.WriteLine("The string {0} is not an Anagram of the string {1}", str1, str2);
                        break;
                    }
                }
                if (anagram)
                {
                    Console.WriteLine("The string {0} is Anagram of the string {1}", str1, str2);
                }
            }
            else
            {
                Console.WriteLine("The string {0} is not an Anagram of the string {1}", str1, str2);
            }            
        }
        
    }
}
