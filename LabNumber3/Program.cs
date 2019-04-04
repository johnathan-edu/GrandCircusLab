using System;

namespace LabNumber3
{
    class Program
    {
        static int Number { get; set; }

        static void Main(string[] args)
        {
            User.GetUserName();
            GetNumber();
            Console.WriteLine(GetValueFromInt());
            Console.WriteLine($"Well, I hope that was as enjoyable for you {User.Name} as it was for me.");
            Console.WriteLine("See ya later!");
            Console.ReadLine();
        }

        static void GetNumber(string validity = "number")
        {
            try
            {
                Console.Write($"{User.Name} please enter a {validity} between 1 and 100: ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 2 || Number > 99)
                {
                    GetNumber("VALID number");
                }
            }
            catch (FormatException)
            {
                GetNumber("number value that is");
            }
        }

        static string GetValueFromInt()
        {
            if (Number % 2 == 1 )
            {
                if (Number > 60)
                {
                    return $"Odd and greater than 60";
                }

                return $"{Number}, Odd";
            }

            if (2 <= Number && Number <= 25)
            {
                return "Even and less than 25";
            }

            if (26 <= Number && Number <= 60)
            {
                return "Even";
            }

            return $"{Number}, Even";
        }
    }
}
