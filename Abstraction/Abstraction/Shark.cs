using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Shark : Fish
    {
        public override string Class { get; set; }

        public override void PrintFishSound()
        {
            Console.WriteLine("Sharks do not produce sound because they don't have an organ capable of making it.");
        }
        public void PrintSharkChars(string phylum, string cl)
        { 
            Class = cl;
            Phylum = phylum;
            Console.WriteLine("Sharks are from class {0} and from phylum {1}", Class, Phylum);
        }

        public override string Name { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public Shark(string name, string color, int size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }
}
