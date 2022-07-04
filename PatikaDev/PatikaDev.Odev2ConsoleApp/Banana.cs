namespace PatikaDev.Odev2ConsoleApp
{
    public class Banana : Fruit
    {
        public override double Vat { get; set; }
        public override double Price { get; set; }

        /// <summary>
        /// Muz'un kdv ve fiyat bilgisi sınıf oluşturulurken set edilmiştir.
        /// </summary>
        /// <param name="vat"></param>
        /// <param name="price"></param>
        public Banana(double vat, double price)
        {
            Vat = vat;
            Price = price;
        }
    }
}
