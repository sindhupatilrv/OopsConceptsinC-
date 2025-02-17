using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicOfCSharp
{
    public class String
    {
        string name = "Learn String";
        public void stringlength()
        {
            Console.WriteLine("String length is :" + name.Length);
        }
        public void indexofString()
        {
            Console.WriteLine("String index value is :" + name.IndexOf('e'));
        }
        public void insert()
        {
            Console.WriteLine("String insert concepts :" + name.Insert(12, "Insert methods"));
        }
        public void replace()
        {
            Console.WriteLine("String replace concepts :" + name.Replace("Learn", "Adavance"));
        }
        public void upperletter()
        {
            Console.WriteLine("String to uppper letter :" + name.ToUpper());
        }
        public void substring()
        {
            // it will display from from 4th char
            Console.WriteLine("String to uppper letter :" + name.Substring(3));
        }

        // Find invalid password based on special char

        public void findInvalidPasswordBasedonInput()
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };
            // string[] mandatoryPasswordRequirement = { 'A }

            if (password.Any(c => notAllowedSymbols.Contains(c)))
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
