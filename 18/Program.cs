using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            char[] arr;
            
            arr = string1.ToCharArray();
            Stack <char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();
            Stack<char> stack3 = new Stack<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                    stack1.Push('!');
                if (arr[i] == '[')
                    stack2.Push('!');
                if (arr[i] == '{')
                    stack3.Push('!');
                if (arr[i] == ')')
                {
                    if (stack1.Contains('!'))
                        stack1.Pop();
                    else
                        Console.WriteLine("Ошибка");
                }
                if (arr[i] == ']')
                {
                    if (stack2.Contains('!'))
                        stack2.Pop();
                    else
                        Console.WriteLine("Ошибка");
                }
                if (arr[i] == '}')
                {
                    if (stack3.Contains('!'))
                        stack3.Pop();
                    else
                        Console.WriteLine("Ошибка");
                }
                

            }    
            Console.ReadKey();
        }
    }
}