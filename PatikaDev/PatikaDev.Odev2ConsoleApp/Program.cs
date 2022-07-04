using System;

namespace PatikaDev.Odev2ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Apple ---");
            var appleKg = 5;
            var appleVat = 1.08;
            var apple = new Apple(appleVat, appleKg);
            var appleResult = apple.VatCalculation(1);
            apple.Choppeable();
            Console.WriteLine($"Apple price: {appleResult}");

            Console.WriteLine("--- Banana ---");
            var bananaKg = 2;
            var bananaVat = 1.18;
            var banana = new Banana(bananaVat, bananaKg);
            var bananaResult = banana.VatCalculation(1);
            banana.Choppeable();    
            Console.WriteLine($"Banana price: {bananaResult}");

            Console.WriteLine("--- Orange ---");
            var orangeKg = 3;
            var orangeVat = 1.15;
            var orange = new Orange(orangeVat, orangeKg);
            var orangeResult = orange.VatCalculation(1);
            orange.Choppeable();
            orange.Squeezable();
            Console.WriteLine($"Orange price: {orangeResult}");
        }
    }
}
