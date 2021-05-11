using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Fish : IAnimal
    {
		public abstract void PrintFishSound();
		public void PrintBreathingMethod()
		{
			Console.WriteLine("Fish breathe through their fins.");
		}
		public void PrintAnimalEnvironment()
		{
			Console.WriteLine("Fish live under water.");
		}
		public abstract string Class { get; set; }
		public string Phylum { get; set; }
		public abstract string Name { get; set; }
	}
}
