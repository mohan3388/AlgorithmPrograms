using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class Algorithm
    {
        public int Binary(string[] arr, int start, int end, string key)
        {
            while (start <= end)
            {
                int Midvalue = (start + end) / 2;
                if (key.CompareTo(arr[Midvalue]) == 0)
                {
                    return Midvalue;
                }
                else if (key.CompareTo(arr[Midvalue]) > 0)
                {
                    start = Midvalue + 1;
                }
                else
                {
                    end = Midvalue - 1;
                }

            }
            return -1;
        }
       
        public void InsertionSort(string[] array)
        {
            Console.Write("Unsorted Elements:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine(" ");
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                string temp = array[i];

             
                int j = i - 1;
                while (j >= 0 && temp.Length < array[j].Length)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        
        }

        public void bubbleSort(int[] arr)
        {

            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

        }

        public void Display(String[] str)
        {
            Console.Write("Sorted Elemnets is: ");
            foreach (var elements in str)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine(" ");
        }
        public void Displaybubble(int[] arr)
        {
            Console.Write("Sorted Elemnets is: ");
            foreach (var elements in arr)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine(" ");
        }
    }
}