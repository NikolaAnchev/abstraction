using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Mammals : IAnimal
    {
		public abstract void PrintMammalSound();
		public void PrintBreathingMethod()
		{
			Console.WriteLine("Mammals breathe through their lungs.");
		}
		public void PrintAnimalEnvironment()
		{
			Console.WriteLine("Mammals live mostly on dry land.");
		}
		public abstract string Family { get; set; }
		public string Genus { get; set; }
	}
}
