using System;

namespace FirstConsoleProject
{
    //class variables
    class Animal
    {
        public static int Count = 0;

        public string name;
        public int age;
        public float happiness;
        //access modifiers (protection level/scope): private, public, static; default (if not declared) is private

        //class constructors
        public Animal ()
        {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;

            Count++;
        }

        public Animal (string _name, int _age, float _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            Count++;
        }

        //class methods
        public void Print ()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
    }
    class MainClass
    {
        public static void Main(string[] args) //this is a method called "Main". It is called when the program starts.
        {
            //Classes
            Animal dog = new Animal();
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Mr. Beans", 10, 0.8f);
            cat.Print();

            Console.WriteLine();
            Console.WriteLine("Number of Animals: " + Animal.Count);

            Console.ReadKey();
        }
    }
}