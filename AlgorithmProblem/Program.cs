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
            Console.WriteLine("press 1 to display binary search\n press 2 to display insertion sort\n press 3 to display bubble sort");
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
                case 0:
                    check = false;
                    break;
            }
        }
    }
}