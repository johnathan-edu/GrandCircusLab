using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                GetsPerimeter();
            }
            while (Continue());

            Console.WriteLine("Come back soon! :) ");
            Console.ReadLine();
        }

        private static void GetsPerimeter()
        {
            var room = new RoomSize();

            Console.Write("What is the length of the room? - ");
            room.Length = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the width of the room? - ");
            room.Width = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the height of the room? - ");
            room.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Perimeter: {room.Perimeter}, Area: {room.Area}, Volume: {room.Volume} \n");
        }

        private static bool Continue()
        {
            Console.Write("Would you like to calculate another room? - ");
            string cont = Console.ReadLine().ToLower();
            Console.WriteLine("");

            if(cont == "yes")
            {
                return true;
            }
            else if(cont == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Incorrect input. Please respond 'Yes' or 'No'.");
                return Continue();
            }
        }
    }
}
