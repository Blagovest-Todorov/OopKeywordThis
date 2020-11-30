using System;

namespace _06.OopAccessModifiers
{

    class Cat
    {
        //public is the most accessible form all classes , from everithere
        public string name;  //accessible at any class level
    }
    internal class Mammal  //internal --accessible only in the currenassembly - ie the project ;
    {
        protected int age; //member is accesible at the Parent class and all child classes
    }


    class Person : Mammal
    {
        private string name;  //accessible at the class level itself only
        //private int age;

        readonly Random rand;


        public Person(string name, int age)
        {
            this.name = name;// this referes the object over which the method is called /this refers to the curr instance
            this.age = age;
            rand = new Random();
        }

        public const int MinAge = 0;
        public const int MaxAge = 150;


        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                int newAge = value;
                if (newAge < MinAge || newAge > MaxAge)
                {
                    throw new ArgumentOutOfRangeException("The value must be between 0 and 200 ");
                }
                this.age = value;
            }

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    this.name = value;
                }
            }
        }

        public void Introduce()
        {
            string name = "Drugi ime";
            Console.WriteLine("Hello! , my name is {0} and i am {1}-years-old.", 
                               this.name, this.age);
             //this improves code readability and prevents mistakes, this referes to the object ! 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Pesho", 21); //here constuctor is making the object instance
            p.Introduce();  ///this refers to an  object instance, this -> is the field name coming form teh class, 
            //this does not come as avariable from the method, this come replaces teh field name, 
            //coming from the class, this is more readable, and prevents mistakes ! this improve the code readability ! 
        }
    }
}



