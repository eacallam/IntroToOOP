using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //FIELDS
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        //PROPERTIES
        
        //CONSTRUCTOR (default)
        public Dog()
        {

        }

        //BEHAVIORS
        public void Run()
        {
            Console.WriteLine("I am running so fast!");
        }

        public void Bark()
        {
            Console.WriteLine("BARK!");
        }

        public void Potty()
        {
            Console.WriteLine("I went to the bathroom.");
        }

        public void Cuddle()
        {
            Console.WriteLine("Aww, I love cuddling!");
        }
    }
}
