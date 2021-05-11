using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Wolf myWolf = new Wolf();
            myWolf.printIntroduction();
            myWolf.PrintAnimalEnvironment();
            myWolf.PrintMammalSound();
            myWolf.PrintWolfChars("Canidae", "Canis");
            Console.WriteLine("\n");
            Shark myShark = new Shark("White shark", "white", 200);
            myShark.PrintAnimalEnvironment();
            myShark.PrintFishSound();
            myShark.PrintSharkChars("Chondrichthyes", "Chordata");
            
            var sharks = new List<Fish>();
            sharks.Add(new Shark("Blakcnose shark", "black", 38));
            sharks.Add(new Shark("Brown shark", "brown with white and dark spots", 50));
            sharks.Add(new Shark("Grey reef shark", "gray", 135));

            Console.WriteLine("\nShark type names:");
            foreach (var Shark in sharks)
            {
                Console.WriteLine("\t{0}", Shark.Name);
            }
        }
    }
}
