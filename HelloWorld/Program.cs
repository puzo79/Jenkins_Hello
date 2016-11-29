//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static int addTwoThings(int thingOne, int thingTwo)
        {
            return thingOne + thingTwo;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(addTwoThings(1, 4));
            System.Console.WriteLine("Hello World");
        }
    }
}

