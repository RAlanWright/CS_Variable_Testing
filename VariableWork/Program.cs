using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was {0} years old", characterAge);
            Console.WriteLine("He really liked the name {0}", characterName);
            Console.WriteLine("But didn't like being {0} years old", characterAge);


            Console.ReadLine();

        }
    }
}
