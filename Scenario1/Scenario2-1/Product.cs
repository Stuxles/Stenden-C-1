using System;

namespace Scenario2_1
{
    public class Product
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty", "Name");
                }
                else
                {
                    name = value;
                }
            }
        }
    }
}