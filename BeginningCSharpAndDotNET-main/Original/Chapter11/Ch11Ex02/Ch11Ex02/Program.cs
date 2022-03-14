﻿using System;

namespace Ch11Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalCollection animalCollection = new AnimalCollection();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Mary"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();
        }
    }
}
