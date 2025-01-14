using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    internal class Product
    {
        public string name; public int quantity; public double price;


        public string CreateProduct()
        {
            return $"Dados do produto: {name}, $ {price}, {quantity} unidades, Total $ {quantity * (double)price:F2}";
        }

        public string GetStock()
        {
            return $"Dados atualizados: {name}, $ {price:F2}, {quantity} unidades, Total $ {quantity * (double)price:F2}";
        }


        public void AddStockProducts(int quantity)
        {
            this.quantity += quantity;

        }

        public void RmStockProducts(int quantity)
        {

            if (this.quantity > quantity && this.quantity - quantity >= 0)
            {
                this.quantity -= quantity;

            }
        }
    }
}
