﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new();

            sb.AppendLine("Nome do Produto: " + Name);
            sb.AppendLine("Produto: R$ " + Price.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
