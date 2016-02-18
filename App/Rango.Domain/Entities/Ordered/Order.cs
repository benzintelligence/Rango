using System;
using System.Collections.Generic;
using Rango.Domain.Entities.Shop;

namespace Rango.Domain.Entities.Ordered
{
    public class Order
    {
        public Order(decimal totalValue)
        {
            
        }

        #region Properties
        public int Id { get; private set; }

        public decimal TotalValue { get; private set; }

        public DateTime Date { get; private set; }

        public Client Client { get; private set; }

        public Store Store { get; private set; }

        public List<OrderItem> OrderItems { get; private set; }

        public List<PaymentMethod> PaymentMethodsProvide { get; private set; }
        #endregion

        #region Methods
        private void Validate()
        {

        }
        #endregion
    }
}