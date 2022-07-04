using System;

namespace PatikaDev.Odev2ConsoleApp
{
    public class Orange : Fruit
    {
        public override double Vat { get; set; }
        public override double Price { get; set; }

        /// <summary>
        /// Portakal'ın kdv ve fiyat bilgisi sınıf oluşturulurken set edilmiştir.
        /// </summary>
        /// <param name="vat"></param>
        /// <param name="price"></param>
        public Orange(double vat, double price)
        {
            Vat = vat;
            Price = price;
        }

        /// <summary>
        /// Sadece portakal sıkılabilir meyve olarak düşünülmüştür.
        /// </summary>
        public void Squeezable()
        {
            Console.WriteLine("Fruit Squeezabled");
        }
    }
}
