using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_ShoeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fills a list with some shoes
            List<Shoe> shoes = new List<Shoe>();

            shoes.Add(new Shoe("Brown", 38, "Nike"));
            shoes.Add(new Shoe("Black", 41, "Adidas"));
            shoes.Add(new Shoe("Black", 35, "Puma"));
            shoes.Add(new Shoe("White", 40, "Nike"));
            shoes.Add(new Shoe("Black", 45, "Nike"));
            shoes.Add(new Shoe("White", 42, "Puma"));
            shoes.Add(new Shoe("Brown", 39, "Puma"));
            shoes.Add(new Shoe("Black", 39, "Nike"));
            shoes.Add(new Shoe("Brown", 44, "Adidas"));
            shoes.Add(new Shoe("Black", 46, "Nike"));

            // Using Lambda to find all brown shoes
            Console.WriteLine("All brown shoes:");
            foreach (var shoe in shoes.FindAll(c => c.Color == "Brown"))
            {
                Console.WriteLine($"{ shoe.Brand}, { shoe.Size}");
            }
            Console.WriteLine("-------------------------------------------");

            // Calls method 'FindShoeBySize'
            Console.WriteLine("All shoes bigger than size 43:");
            foreach (var shoe in shoes.FindAll(FindShoeBySize))
            {
                Console.WriteLine($"{ shoe.Brand}, { shoe.Size}");
            }
            Console.WriteLine("-------------------------------------------");

        }

        // Named method that returns true if more than size 43
        static bool FindShoeBySize(Shoe thisShoe)
        {
            return thisShoe.Size > 43;
        }
    }
}
