using System;

namespace PatikaDev.Odev2ConsoleApp
{
    public abstract class Fruit
    {
        public virtual double Vat { get; set; }
        public virtual double Price { get; set; }

        public virtual double VatCalculation(double kg)
        {
            return Price * kg * Vat / 100;
        }

        public virtual void Choppeable()
        {
            Console.WriteLine("Fruit Chopped");
        }
    }
}
