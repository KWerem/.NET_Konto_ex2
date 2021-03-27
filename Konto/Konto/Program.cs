using System;

namespace Konto
{
    class Program
    {
        static void Main(string[] args)
        {
            Account k = new Account("Jan Kowalski", "37562", "mała", "czarna");
            k.Zaloguj("mała", "czarna");
            Console.WriteLine(k);

            k.Wpłać(500);
            k.Wypłać(316);

            k.ZmieńHasło("latte");
            k.Zaloguj("mała", "latte");
            Console.WriteLine(k);

            Console.WriteLine("\nNaciśnij <Enter>, aby wylogowac");
            while (Console.ReadKey().Key == ConsoleKey.Enter) { k.Wyloguj(); }


            //Account o = new Operacje(500)


        }
    }
}
