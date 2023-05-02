using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    internal class Product
    {
        List<string> parts;
        public Product()
        {
            parts = new List<string>();
        }

        public void Add(string part)
        {
            parts.Add(part);
        }

        public string Display()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Ground components are :");
            foreach (string part in parts)
            {
                result.AppendLine(part);
            }

            return result.ToString();
        }
    }
}
