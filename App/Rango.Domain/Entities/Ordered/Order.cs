using System;
using System.Collections.Generic;
using Rango.Domain.Entities.Shop;

namespace Rango.Domain.Entities.Ordered
{
    public class Order
    {
        public int Id { get; set; }

        public decimal TotalValue { get; set; }

        public DateTime Date { get; set; }

        public Client Client { get; set; }

        public Store Store { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public List<PaymentMethod> PaymentMethodsProvide { get; set; }
    }
}