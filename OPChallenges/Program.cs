﻿using System;

namespace OPChallenges
{
    class Program
    {
        class Dog
        {
             string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"the dog {name} has been created.");

            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof, i'm going to eat you alive");
                happiness += 0.2;
            }

            public void Wiggle()
            {
                Console.WriteLine("Wiggle-wiggle, its my life");
            }

            public void Rename(string newName)
            {
                name = newName;

            }

            public void ShowDogData()
            {
                Console.WriteLine($"Name: {name}; Spots: {spots}; Happy: {happiness};");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog newDog = new Dog("Tommy", 10);
            
            
            Console.WriteLine($"the level of happiness: {newDog.Happiness}");

            while(newDog.Happiness != 1)
            {
                newDog.Barks();
            }

            newDog.Wiggle();

            Console.WriteLine("Name the dog;");
            string newDog = Console.ReadLine();
            newDog.Rename(newDogName);
            newDog.ShowDogData();

        }
    }
}
