using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Entities.Enums;

namespace Orders.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Client Client { get; set; } 
        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RmItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (OrderItem item in OrderItems) {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("");


            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine("");


            sb.Append("Client: ");
            sb.Append(Client.Name + " ");
            sb.Append(Client.Birthday.ToString("dd/MM/yyyy") + " - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("");

            sb.AppendLine("Order items:");

            double totalPrice = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.Product.Name + ", $" +
                    item.Product.Price + ", Quantity: " + item.Quantity +
                     ", Subtotal: $" + item.SubTotal());

                totalPrice += item.SubTotal();
            }

            sb.AppendLine("Total price: $" + totalPrice);

            return sb.ToString();
        }
    }
}
