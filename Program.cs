using System;

namespace anders
{
    class Program
     {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("-Huvudmeny-");
            Console.WriteLine("1. Hello world");
            Console.WriteLine("2. Ditt namn och ålder");
            Console.WriteLine("3. Ändra textfärg");
            Console.WriteLine("4. Dagens datum");
            Console.WriteLine("5. Vilket tal är störst?");
            Console.WriteLine("0. Avsluta");
            Console.Write("\r\nAnge ditt val:");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nHello world! ");
                    Console.Write("\ntryck på valfri tangent för att gå tillbaka till huvudmenyn.");
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.WriteLine("\nVad heter du i förnamn?");
                    var name = Console.ReadLine();
                    Console.WriteLine("\noch vad är ditt efternamn?");
                    var lastname = Console.ReadLine();
                    Console.WriteLine("\nVad är din ålder? ");
                    var age = Console.ReadLine();
                    Console.WriteLine($"\nHej, {name} {lastname}, du är {age} år gammal!");
                    Console.Write("\ntryck på valfri tangent för att gå tillbaka till huvudmenyn.");
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nNu bytte texten färg!");
                    Console.ResetColor();
                    Console.Write("\ntryck på valfri tangent för att gå tillbaka till huvudmenyn.");
                    Console.ReadKey();
                    return true;
                case "4":
                    var date = DateTime.Now;
                    Console.WriteLine(value: $"\nHej, dagens datum är {date}");
                    Console.Write("\ntryck på valfri tangent för att gå tillbaka till huvudmenyn.");
                    Console.ReadKey();
                    return true;
                case "5":
                    int a;
                    int b;
                    int stor;
                    Console.WriteLine("\nSkriv ett tal");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nskriv ett annat tal");
                    b = Convert.ToInt32(Console.ReadLine());
                    if (a > b) stor = a;
                    else stor = b;
                    Console.WriteLine("\nDet största talet är {0}", stor);
                    Console.Write("\ntryck på valfri tangent för att gå tillbaka till huvudmenyn.");
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }

        }
    }
}