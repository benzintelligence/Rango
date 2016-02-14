namespace Rango.Domain.Entities.Products
{
    public class Product
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }
    }
}