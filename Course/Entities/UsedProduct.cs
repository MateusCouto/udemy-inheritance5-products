using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price,DateTime manufacturedate) : base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new();

            sb.AppendLine(base.PriceTag());
            sb.AppendLine("Manufacture: " + ManufactureDate.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Produto (Usado): R$ " + Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("--------------------------------------------");

            return sb.ToString();

        }
    }
}
