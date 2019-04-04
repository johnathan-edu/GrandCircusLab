using System;

namespace LabNumber3
{
    class User
    {
        public static string Name { get; set; }

        public static void GetUserName()
        {
            Console.Write("Hello there. Today I will be taking a number from you and returning you a result based upon that answer. \n" +
                                "How rude of me! I forgot to ask what your name was... ");
            Name = Console.ReadLine();
            Console.WriteLine($"Well it's very nice to meet you {Name}!");
        }
    }
}
