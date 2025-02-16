using System;
using System.Resources;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args) 
       {
            Console.WriteLine("Learn C#");
            readanddisplaysetofArray();
            dynamicArray();
        }

        private static void readanddisplaysetofArray()
        {
            int[] ints = { 1, 2, 3 };
            Console.WriteLine("The lenght of the array is:" + ints.Length);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
          
        }

        private static void dynamicArray()
        {
            int[] ints = [];
            var valuefromConsole = int.Parse(Console.ReadLine());
            

        }
    }
}