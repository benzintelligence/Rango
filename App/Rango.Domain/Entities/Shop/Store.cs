namespace Rango.Domain.Entities.Shop
{
    public class Store
    {
        public string CompanyName { get; set; }

        public string FantasyName { get; set; }

        public string CNPJ { get; set; }

        public string ImageUrl { get; set; }

        public bool MakeDelivery { get; set; }

        public string DeliveryTime { get; set; }

        public decimal DeliveryFee { get; set; }

        public string Culinary { get; set; }

        // Cardápio
    }
}