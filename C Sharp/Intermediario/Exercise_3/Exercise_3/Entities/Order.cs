using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_3.Entities.Enums;

namespace Exercise_3.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
 
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double total()
        {
            double sum = 0.0;

            //verify sum logic operation to this case
            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order Moment:" + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            //do conversion enum to string
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("ORDER ITEMS: ");
            foreach (OrderItem item in Items)
            {

                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }


    
}
