using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
	class Wolf : Mammals
	{
        public override string Family { get; set; }

        public void printIntroduction()
		{
			Console.WriteLine("The wolf is a mammal.");
		}
		public override void PrintMammalSound()
		{
			Console.WriteLine("The wolf barks, whimpers, gworls and howls.");
		}
		public void PrintWolfChars(string family, string genus)
		{
			Family = family;
			Genus = genus;
			Console.WriteLine("Sharks are from class {0} and from phylum {1}", Family, Genus);
		}
	}
}
