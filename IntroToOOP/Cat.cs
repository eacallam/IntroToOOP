using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //FIELDS (instance variables that belong to the class. Every cat instance that is created has these fields, which can be manipulated)
        private string name; //private means these FIELDS are only accessible by the class so only the instance of the class has access but will have a PUBLIC property
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry;

        //PROPERTIES (serves as the "middleman" to allow access; allows code outside of the class to access the field)
        public string Name//This is a public property, use Pascal case; we name it the same as the private field
        {
            get { return this.name; }
            set { this.name = value; } //refers to the instance of that object

            //Some values you just get and some values you just set.
        }

        public int Age
        {
            get { return this.age; }  //we don't want to set the age (we want it to start at 0, the default value) so we just put a get.
        }


        //CONSTRUCTOR - always same name as class. Can have as many as you need as long as they have a unique signature.
        //This is the default constructor (no parameters). If you don't, it'll create one for you, but can cause issues later if you don't create one.
        public Cat()
        {
            this.name = "Mittens"; //if you wanted this to be the default
        }

        //OVERLOADING the constructor with different parameters
        //Where you set the values of the fields, instance variables
        public Cat(string name, string furColor, int furLength, bool isMale, int age, bool isHungry)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
        }

        //Constructor with one parameter
        public Cat(string name)
        {
            this.name = name;
        }
        
        //Constructor with one parameter; has to be a different data type, since we already have a single string parameter - can't do another single string parameter (e.g. but could do two!)
        //public Cat(string furColor)
        //{
        //    this.furColor = furColor;
        //}
    }
}
