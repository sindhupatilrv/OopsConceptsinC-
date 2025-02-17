using System;
using System.Resources;

namespace BasicOfCSharp
{
    public class Program
    {
        public static void Main(string[] args) 
       {
            Console.WriteLine("Learn C#");
            Console.WriteLine("------------------Learn the Array started--------------");
            readanddisplaysetofArray();
           // dynamicArray();
            Console.WriteLine("------------------Learn the Array ended--------------");

            Console.WriteLine("------------------Learn the String START--------------");
            String learnstring = new String();
            learnstring.stringlength();
            learnstring.indexofString();
            learnstring.insert();
            learnstring.replace();
            learnstring.upperletter();
            learnstring.substring();
            learnstring.findInvalidPasswordBasedonInput();

            string s = "SoloLearn";
            int x = s.Length;
            int y = s.IndexOf("e");
            Console.WriteLine(x % y);
            Console.WriteLine("------------------Learn the String End--------------");
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