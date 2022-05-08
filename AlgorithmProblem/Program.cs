using System;
using AlgorithmProblem;
public class Program
{
    const string File_Path = @"D:\dotnet\algorithms\AlgorithmPrograms\AlgorithmProblem\Utility\Element.txt";
    public static void Main(String[] args)
    {
        bool check=true;
        while(check)
        {
            Console.WriteLine("press 1 to display binary search");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
               case 1:
                    Algorithm problem = new Algorithm();
                    string Input_File = File.ReadAllText(File_Path);
                    string[] arr = Input_File.Split(',');
                    Console.WriteLine("Enter word to search");
                    int lengthvalue=arr.Length;
                    string key = Console.ReadLine();
                    int result = problem.Binary(arr,0, lengthvalue - 1,key);
                    if(result == -1)
                    {
                        Console.WriteLine(key+"word is present");
                    }
                    else
                    {
                        Console.WriteLine(key + "word is not present");
                    }
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}