using System;
using AlgorithmProblem;
public class Program
{
    const string File_Path = @"D:\dotnet\algorithms\AlgorithmPrograms\AlgorithmProblem\Utility\Element.txt";
    public static void Main(String[] args)
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("press 1 to display binary search\npress 2 to display insertion sort\npress 3 to display bubble sort\npress 4 to display merge sort");
            Algorithm problem = new Algorithm();
            string Input_File = File.ReadAllText(File_Path);
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   
                    string[] arr = Input_File.Split(',');
                    Console.WriteLine("Enter word to search");
                    int lengthvalue = arr.Length;
                    string key = Console.ReadLine();
                    int result = problem.Binary(arr, 0, lengthvalue - 1, key);
                    if (result == -1)
                    {
                        Console.WriteLine(key + "word is present");
                    }
                    else
                    {
                        Console.WriteLine(key + "word is not present");
                    }
                    break;
                case 2:
                    string[] input_Array = Input_File.Split(',');

                    problem.InsertionSort(input_Array);
                    problem.Display(input_Array);
                        break;
                case 3:
                    int[] array = { 78, 55, 45, 98, 13 };

                    problem.bubbleSort(array);
                    problem.Displaybubble(array);
                    break;
                case 4:
                    Algorithm mergesort = new Algorithm();
                    int[] arr2 = { 12, 11, 13, 5, 6, 7 };
                    Console.WriteLine("unsorted array");
                    mergesort.printArray(arr2);
                    mergesort.Sorting(arr2, 0, arr2.Length - 1);
                    Console.WriteLine("\nsorted array");
                    mergesort.printArray(arr2);
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}