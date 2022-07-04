namespace PatikaDev.Odev2ConsoleApp
{
    public class Apple : Fruit
    {
        public override double Vat { get; set; }
        public override double Price { get; set; }

        /// <summary>
        /// Elma'nın kdv ve fiyat bilgisi sınıf oluşturulurken set edilmiştir.
        /// </summary>
        /// <param name="vat"></param>
        /// <param name="price"></param>
        public Apple(double vat, double price)
        {
            Vat = vat;
            Price = price;
        }

        /// <summary>
        /// Sadece elmaya özel kdv hesaplamanın farklı yapıldığı varsayılır. Bu sebeple override edilmiştir.
        /// </summary>
        /// <param name="kg"></param>
        /// <returns></returns>
        public override double VatCalculation(double kg)
        {
            return Price * kg * Vat / 1000;
        }
    }
}
