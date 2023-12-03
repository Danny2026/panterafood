using System;

namespace Product
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductWeight { get; set; }

        public void SetPrice(int price)
        {
            if (price >= 0)
                ProductPrice = price;
            else Console.WriteLine("Цена не может быть отрицательной");
        }

        public void SetWeight(int weight)
        {
            if (weight >= 0)
                ProductWeight = weight;
            else Console.WriteLine("Вес не может быть отрицательным");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
