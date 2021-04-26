using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class ImportedProduct: Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price)
        {
            CustomsFee = customsfee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            StringBuilder sb = new();

            sb.AppendLine(base.PriceTag());
            sb.AppendLine("Taxa: " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Produto (Importado): R$ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("--------------------------------------------");

            //Total += TotalPrice();

            return sb.ToString();
        }
    }
}
