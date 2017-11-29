using System.Globalization;

namespace Scenario2_3
{
    public class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            string s = string.Format("{0:C}", price);
            return "Product: " + name + " " + s;
        }
    }
}