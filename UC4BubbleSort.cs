using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1617Algorithm
{
    internal class UC4BubbleSort
    {
        public void bubbleSort()
        {
            //read the element from the user
            Console.Write("Enter the number of elements: ");
            int element = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[element];
            Console.Write("Enter the {0} integer elements.", element);
            for(int i = 0; i < element; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            //display the list
            Console.Write("The integer elements are: ");
            for (int i = 0; i < element; i++)
            {
                Console.Write(ints[i] + " ");
            }

            //sort the list
            for(int i = 0; i < element - 1; i++)
            {
                for(int j = 0; j < element - i - 1; j++)
                {
                    if (ints[j] > ints[j+1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j+1];
                        ints[j+1] = temp;
                    }
                }
            }

            //display the list
            Console.Write("The integer elements in the ascending order are: ");
            for (int i = 0; i < element; i++)
            {
                Console.Write(ints[i] + " ");
            }

        }
        
    }
}
