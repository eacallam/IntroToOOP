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
        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }


        //CONSTRUCTOR (default)
        public Dog()
        {

        }

        //CONSTRUCTOR (overload)
        public Dog (int hairLength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
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

        public void Cuddle(string name)
        {
            Console.WriteLine("Aww, I love cuddling with {0}!", name);
        }
    }
}
