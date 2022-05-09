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
            Console.Write("Unsorted Elements:->");
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
            Console.Write("Sorted Elemnets is:-> ");
            foreach (var elements in str)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine(" ");
        }
        public void merge(int[] arr, int left, int mid, int right)
        {

            int n1 = mid - left + 1;
            int n2 = right - mid;
          
            int[] Left = new int[n1];
            int[] Right = new int[n2];
            int i, j;

            
            for (i = 0; i < n1; ++i)
                Left[i] = arr[left + i];
            for (j = 0; j < n2; ++j)
                Right[j] = arr[mid + 1 + j];

         
            i = 0;
           j = 0;

           
            int k = left;
            while (i < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    arr[k] = Left[i];
                    i++;
               }
               else
               {
                  arr[k] = Right[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = Left[i];
                i++;
                k++;
            }

            
            while (j < n2)
            {
                arr[k] = Right[j];
                j++;
                k++;
            }
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

        public void Sorting(int[] arr, int left, int right)
        {
            if (left < right)
            {
               
               int mid = left + (right - left) / 2;

               Sorting(arr, left, mid);
               Sorting(arr, mid + 1, right);

               
                merge(arr, left, mid, right);
           }
        }

        
        public void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        //Anagram
        public bool Anagram(string firstlength, string secondlength)
        {
            var val1 = firstlength.ToLower().ToArray();
            var val2 = secondlength.ToLower().ToArray();
            Array.Sort(val1);
            Array.Sort(val2);
            return new string(val1) == new string(val2);
           
        }
    }
}