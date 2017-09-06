using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of Cat
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("neko", "black", 3, true, 1, true);

            Console.WriteLine(cat1.Name); //gets name of first cat
            Console.WriteLine(cat2.Name); //gets name of second cat

            cat1.Name = "gato";
            Console.WriteLine(cat1.Name); //change name of cat
            Console.WriteLine(cat1.Age);

           // cat1.furColor = "red"; cannot do this until you have a public property to access (will say it is "inaccessible due to its protection level"). BUT can still set it using the constuctor. But can't access it!
        }
    }
}
