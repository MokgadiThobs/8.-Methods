using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //callinga method, this can be done many times, metods and functions
            //aare literrally the dame in C#, preferably call them methods
            SayHi();
            //Methods with parameters
            SayHiUser("Mokgadi");

            //Method with more parameters
            SayHiAge("John", 55);
            //freexing the console
            Console.ReadLine();
        }
        //craeting a method, ignore static for now, use capitals a per  conversation.
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        //method with one parameter
        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        //method  with many parameters
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Helo " + name + " you are " + age);
        }
    }
}
