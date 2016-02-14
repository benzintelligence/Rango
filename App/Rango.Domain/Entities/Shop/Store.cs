using System.Collections.Generic;
using Rango.Domain.Entities.Products;

namespace Rango.Domain.Entities.Shop
{
    public class Store
    {
        public string CompanyName { get; set; }

        public string FantasyName { get; set; }

        public string Cnpj { get; set; }

        public string ImageUrl { get; set; }

        public bool MakeDelivery { get; set; }

        public string DeliveryTime { get; set; }

        public decimal DeliveryFee { get; set; }

        public string DeliveryDistance { get; set; }

        public Address Address { get; set; }

        public List<Telephone> Telephones { get; set; }

        public List<PageLink> PageLinks { get; set; }

        public List<Culinary> Culinaries { get; set; }

        public List<Product> Products { get; set; }

        public List<PaymentMethod> PaymentMethods { get; set; }

        public WorkHours WorkHours { get; set; }
    }
}